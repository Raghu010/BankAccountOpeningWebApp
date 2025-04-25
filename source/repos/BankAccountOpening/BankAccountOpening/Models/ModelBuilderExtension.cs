using Microsoft.EntityFrameworkCore;

namespace BankAccountOpening.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<States>().HasData(
            new States { StateId = 1, StateName = "Andhra Pradesh" },
            new States { StateId = 2, StateName = "Arunachal Pradesh" },
            new States { StateId = 3, StateName = "Assam" },
            new States { StateId = 4, StateName = "Bihar" },
            new States { StateId = 5, StateName = "Chhattisgarh" },
            new States { StateId = 6, StateName = "Goa" },
            new States { StateId = 7, StateName = "Gujarat" },
            new States { StateId = 8, StateName = "Haryana" },
            new States { StateId = 9, StateName = "Himachal Pradesh" },
            new States { StateId = 10, StateName = "Jharkhand" },
            new States { StateId = 11, StateName = "Karnataka" },
            new States { StateId = 12, StateName = "Kerala" },
            new States { StateId = 13, StateName = "Madhya Pradesh" },
            new States { StateId = 14, StateName = "Maharashtra" },
            new States { StateId = 15, StateName = "Manipur" },
            new States { StateId = 16, StateName = "Meghalaya" },
            new States { StateId = 17, StateName = "Mizoram" },
            new States { StateId = 18, StateName = "Nagaland" },
            new States { StateId = 19, StateName = "Odisha" },
            new States { StateId = 20, StateName = "Punjab" },
            new States { StateId = 21, StateName = "Rajasthan" },
            new States { StateId = 22, StateName = "Sikkim" },
            new States { StateId = 23, StateName = "Tamil Nadu" },
            new States { StateId = 24, StateName = "Telangana" },
            new States { StateId = 25, StateName = "Tripura" },
            new States { StateId = 26, StateName = "Uttar Pradesh" },
            new States { StateId = 27, StateName = "Uttarakhand" },
            new States { StateId = 28, StateName = "West Bengal" },
            new States { StateId = 29, StateName = "Andaman and Nicobar Islands" },
            new States { StateId = 30, StateName = "Chandigarh" },
            new States { StateId = 31, StateName = "Dadra and Nagar Haveli and Daman and Diu" },
            new States { StateId = 32, StateName = "Delhi" },
            new States { StateId = 33, StateName = "Jammu and Kashmir" },
            new States { StateId = 34, StateName = "Ladakh" },
            new States { StateId = 35, StateName = "Lakshadweep" },
            new States { StateId = 36, StateName = "Puducherry" }
            );
        }
    }
}
