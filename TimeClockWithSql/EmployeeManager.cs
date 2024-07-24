using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClockWithSql
{
    internal class EmployeeManager
    {
        private static string _loginSQL = "\r\ndeclare  @code int, @answer VARCHAR(250), @fullName VARCHAR(20)='';\r\n--INSERT INTO Employes (Full_name, Employ_id) VALUES (@fulName, @id);\r\n-- האם הוא קיים, משיכה של קוד\r\nIF exists (select * from Employes WHERE Employ_id = @id)\r\n\tBEGIN\r\n\t\tSELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);\r\n\tEND\r\nELSE\r\n\tBEGIN\r\n\t\t--הוספת עובד לטבלה\r\n\t\tINSERT INTO Employes VALUES (@fullName, @ID);\r\n\t\tSELECT @code = @@IDENTITY;\r\n\tEND\r\n--בדיקת סיסמה\r\nIF exists (select * from Passwords WHERE Employe_Code = @code)\r\n\tBEGIN\r\n\t\tIF exists (SELECT User_password FROM Passwords\r\n\t\t\t\t\tWHERE Employe_Code = @code\r\n\t\t\t\t\tAND User_password = @passwords\r\n\t\t\t\t\tAND Is_active = 1 )\r\n\t\t\tBEGIN\r\n\t\t\t\tIF exists (SELECT User_password FROM Passwords\r\n\t\t\t\t\t\t\tWHERE Employe_Code = @code\r\n\t\t\t\t\t\t\tAND User_password = @passwords\r\n\t\t\t\t\t\t\tAND Is_active = 1\r\n\t\t\t\t\t\t\tAND Password_expiry_date >= GETDATE())\r\n\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t-- בדיקת כניסה ויציאה\r\n\t\t\t\t\t\t\t\tif  exists (SELECT * FROM Time_clock WHERE Employe_Code = @code\r\n\t\t\t\t\t\t\t\t\tAND leaving_time is null)\r\n\t\t\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\t\t--עדכון\r\n\t\t\t\t\t\t\t\t\t\t\tUPDATE Time_clock SET leaving_time = GETDATE() WHERE Employe_Code = @code AND leaving_time is null;\r\n\t\t\t\t\t\t\t\t\t\t\tSELECT @answer = 'exit time' + CONVERT (NVARCHAR , GETDATE(), 121);\r\n\t\t\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tINSERT INTO  Time_clock VALUES (GETDATE(), null, @code);\r\n\t\t\t\t\t\t\t\t\tSELECT @answer = 'Entry time' + CONVERT (NVARCHAR , GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tEND\r\n\t\t\t\t\t\t\tELSE\r\n\t\t\t\t\t\t\t\tBEGIN\r\n\t\t\t\t\t\t\t\t\tSELECT @answer = 'You need to update password';\r\n\t\t\t\t\t\t\t\tEND\r\n\t\t\tEND\r\n\t\t\t\tELSE\r\n\t\t\t\tBEGIN\r\n\t\t\t\t\tSELECT @answer = 'wrong password';\r\n\t\t\t\tEND\r\n\tEND\r\nelse\r\n\tBEGIN\r\n\t\tINSERT INTO Passwords VALUES (@passwords,DATEADD(day, 180, GETDATE()) ,@code , 1);\r\n\t\tSELECT @answer = 'You create A worker and password';\r\n\tEND\r\nselect @answer";
        
        private static string _changePasswordSQL = "\r\ndeclare @code int, @answer varchar(150);\r\nIF exists (select * from Employes WHERE Employ_id = @id)\r\n\tBEGIN\r\n\t\tSELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);\r\n\tEND\r\nIF EXISTS (SELECT * FROM Passwords WHERE Employe_Code = @code)\r\nBEGIN\r\n    IF EXISTS (SELECT User_password FROM Passwords\r\n               WHERE Employe_Code = @code\r\n                 AND User_password = @passwords\r\n                 AND Is_active = 1)\r\n    BEGIN\r\n        IF EXISTS (SELECT User_password FROM Passwords\r\n                   WHERE Employe_Code = @code\r\n                     AND User_password = @passwords\r\n                     AND Is_active = 1\r\n                     AND Password_expiry_date >= GETDATE())\r\n        BEGIN\r\n            -- Prompt for new password and verify it\r\n            IF @new_password = @verify_new_password\r\n            BEGIN\r\n                -- Set current password as inactive\r\n                UPDATE Passwords\r\n                SET Is_active = 0\r\n                WHERE Employe_Code = @code\r\n                  AND User_password = @passwords\r\n                  AND Is_active = 1\r\n                  AND Password_expiry_date >= GETDATE()\r\n                  \r\n                -- Insert the new password\r\n                INSERT INTO Passwords (Employe_Code, User_password, Is_active, Password_expiry_date)\r\n                VALUES (@code, @new_password, 1, DATEADD(month, 6, GETDATE())) -- Example expiry date 6 months from now\r\n                \r\n                select @answer = 'Password updated successfully.'\r\n            END\r\n            ELSE\r\n            BEGIN\r\n                select @answer =  'New password and verification do not match.'\r\n            END\r\n        END\r\n        ELSE\r\n        BEGIN\r\n            select @answer = 'Password has expired.'\r\n        END\r\n    END\r\n    ELSE\r\n    BEGIN\r\n        select @answer = 'Incorrect current password or account is not active.'\r\n    END\r\nEND\r\nELSE\r\nBEGIN\r\n    select @answer = 'Employee code not found.'\r\nEND\r\n\r\nselect @answer";
        public void doX()
        {
        }
        public static string Login(string id, string passwords)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@passwords" };
            string[] values = {id, passwords };
            string res = DBConnection.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return res;
        }
        public static string ChangePassword(string id, string passwords, string new_password, string verify_new_passwords)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            // 3. Return response
            string[] parameters = { "@id", "@passwords", "@new_password", "@verify_new_password" };
            string[] values = { id, passwords, new_password , verify_new_passwords };
            string res = DBConnection.runSQL(_changePasswordSQL, parameters, values);
            return res;
        }

    }
    

}
