using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicArea
{
    internal class Pillar
    {
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _statusLocation;
        public string StatusLocation
        {
            get
            {
                switch (_location)
                {
                    case "privetPlace":
                        return "the pillar is private";


                    case "publicPlace":
                        if (_width < 4)
                        { return "ptorPlace"; }
                        else if (_width >= 4)
                        {
                            if (_height >= 10)
                            {
                                return "privatePlace";
                            }
                            else if (_height < 10 && _width >= 3)
                            {
                                return "carmelit";
                            }
                            else if (_height < 3)
                            {
                                return "publicPlace";
                            }
                            else { return "One of the data is wrong"; }
                        }
                        break;





                    case "carmelit":
                        if (_height >= 10)
                        {
                            if (_width >= 4)
                            {
                                return "privatePlac";
                            }
                            else if (_width < 4)
                            {
                                return " rashi: ptor place." + " atoor: carmelit";
                            }
                        }
                        else if (_width < 10 && _width >= 4)
                        {
                            return "carmelit";
                        }
                        else { return "One of the data is wrong"; }
                        break;

                    default:
                        return " ";




                }
                return " ";
            }
            set { _statusLocation = value; }
        }
        public string publicRoadWway()
        {
            if ((_location == "publicPlace ") && (_width >= 4 && _height < 3 ))
            {
                 return "the pillar is privatePlace";
            }
            else
            {
                return "the pillar is not publicPlace";
            }

        }
        public string privatePplace()
        {
            if ((_location == "privatePlace" ) || ((_location == "publicPlace") && (_width >= 4 && _height >= 10)))
            {
                return "the pillar is privetPlace";
            } 
            else 
            {
                return "the pillar is not privatePlace";
            }
        }
        public string carmelitWay()
        {
            if ((_location == "publicPplace") && ((_height >= 3 && _height < 10) && _width >= 4))
            {
                return "its carmelit";
            }
            else if ((_location == "carmelit") && (_height < 10 && _width >= 4))
            {
                return "its carmelit";
            }
            else if ((_location == "carmelit") && (_width >= 4 && _height == 10))
            {
                return "in the toor its carmelit ";
            }
            else
            {
                return "its not carmelit";
            }

        }
        //public string ptorPlace()
        //{
            //if (_location == "publicPlace" && 
       // }

    }

}








    
    

  