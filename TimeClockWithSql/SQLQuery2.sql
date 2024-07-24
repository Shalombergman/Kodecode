DECLARE 
@code INT,
@passwords NVARCHAR(50),
@new_password NVARCHAR(50),
@verify_new_password NVARCHAR(50)
-- Example values
SET @code = 1
SET @passwords = 1234
SET @new_password = 'new_password'
SET @verify_new_password = 'new_password'


declare @code int, @answer varchar(150);
IF exists (select * from Employes WHERE Employ_id = @id)
	BEGIN
		SELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);
	END
IF EXISTS (SELECT * FROM Passwords WHERE Employe_Code = @code)
BEGIN
    IF EXISTS (SELECT User_password FROM Passwords
               WHERE Employe_Code = @code
                 AND User_password = @passwords
                 AND Is_active = 1)
    BEGIN
        IF EXISTS (SELECT User_password FROM Passwords
                   WHERE Employe_Code = @code
                     AND User_password = @passwords
                     AND Is_active = 1
                     AND Password_expiry_date >= GETDATE())
        BEGIN
            -- Prompt for new password and verify it
            IF @new_password = @verify_new_password
            BEGIN
                -- Set current password as inactive
                UPDATE Passwords
                SET Is_active = 0
                WHERE Employe_Code = @code
                  AND User_password = @passwords
                  AND Is_active = 1
                  AND Password_expiry_date >= GETDATE()
                  
                -- Insert the new password
                INSERT INTO Passwords (Employe_Code, User_password, Is_active, Password_expiry_date)
                VALUES (@code, @new_password, 1, DATEADD(month, 6, GETDATE())) -- Example expiry date 6 months from now
                
                select @answer = 'Password updated successfully.'
            END
            ELSE
            BEGIN
                select @answer =  'New password and verification do not match.'
            END
        END
        ELSE
        BEGIN
            select @answer = 'Password has expired.'
        END
    END
    ELSE
    BEGIN
        select @answer = 'Incorrect current password or account is not active.'
    END
END
ELSE
BEGIN
    select @answer = 'Employee code not found.'
END

select @answer