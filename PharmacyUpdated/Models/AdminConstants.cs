using System.Collections.Generic;

namespace PharmacyUpdated.Models
{
    public class AdminConstants
    {
        public static List<Admin> _admin = new List<Admin>()
        {
            new Admin(){AdminName="admin1",Contact="1234567891",emailId="vtu11204@veltech.edu.in",password="vtu11204",Role="administrator" },
            new Admin(){AdminName="admin2",Contact="1234567895",emailId="admin2@gmail.com",password="admin2",Role="User"}
        };
    }
}
