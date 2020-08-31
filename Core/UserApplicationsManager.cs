using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDesktopGreatAgain.Core
{
    class UserApplicationsManager
    {
        public UserApplicationsManager()
        {

        }

        public List<UserApplication> GetUserApplications()
        {
            var applications = new List<UserApplication>() {
                new UserApplication() {ApplicationName = "App1"},
                new UserApplication() {ApplicationName = "App2"},
                new UserApplication() {ApplicationName = "App3"}
            };

            return applications;
        }
    }
}
