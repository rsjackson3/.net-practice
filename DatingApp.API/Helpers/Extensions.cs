using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            // The Access-Control-Allow-Origin response header indicates whether the response 
            // can be shared with requesting code from the given origin.
        }

        public static int CalculateAge(this DateTime theDateTime) {
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today) {
                age--;
            }
            return age;
        }
    }
}