using System;
using System.Collections.Generic;

namespace Drizzly.Service.Maps
{
    public class Utils
    {
        
        public static double ToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        
        public static Dictionary<string, int> GeographicToTileNumber(double latitude, double longitude, int zoom)
        {
            
            var latitudeRadians = Utils.ToRadians(latitude);
            
            var n = 2 ^ zoom;
            var x = (int)((longitude + 180.0) / 360.0 * (1 << zoom));
            var y = (int)((1.0 - Math.Log(Math.Tan(latitude * Math.PI / 180.0) +  1.0 / Math.Cos(latitude * Math.PI / 180.0)) / Math.PI) / 2.0 * (1 << zoom));
            
            var dict = new Dictionary<string, int>();
            
            dict.Add("x", x);
            dict.Add("y", y);
            
            return dict;
            
        }
        
    }
}