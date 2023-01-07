namespace _5.Writing_Conditionals_That_Convey_Intent
{
    public class Program
    {
        static void Main(string[] args)
        {


            #region Agenda
            /*
             * Clear intent 
             * Bite-size logic 
             * Use the right tool 
             * Sometimes code isn't the answer 
             */

            #endregion

            #region Compare Booleans Implicity

            #region Dirty Code Here
            //if (loggedIn == true)
            #endregion

            #region Clean Code Here
            //if (loggedIn)
            #endregion

            #endregion

            #region Assign Booleans Implicity

            #region Dirty Code Here
            /*
             * bool goingToChipotleForLunch;
             * if (cashInWallet > 6.00)
               {
                goingToChipotleForLunch = true;
               }
               else
               {
                goingToChipotleForLunch = false;
               }
             */
            #endregion

            #region Clean Code Here
            //bool goingToChipotleForLunch = cashInWallet > 6.00;
            #endregion

            #endregion

            #region Be Positive (Donot not be anti-Negative)

            #region Dirty Code Here
            //if (!isNotLoggedIn)
            #endregion

            #region Clean Code Here
            //if (loggedIn)

            #endregion

            #endregion

            #region Ternary is Beautiful

            #region Dirty Code Here
            /*int registrationFee; if (isSpeaker)
            {
                registrationFee = 0;
            }
            else
            {
                registrationFee = 50;
            }
            */
            #endregion

            #region Clean Code Here
            //int registrationFee = isSpeaker ? 0 : 50;

            #endregion

            #endregion

            #region Be Strongly Typed,Not Stringly Typed (Enums)

            #region Dirty Code Here
            //if (employeeType == "manager")
            #endregion

            #region Clean Code Here
            //if (employee.type == EmployeeType.Manager)

            #endregion

            #endregion

            #region Magic Numbers 

            #region Dry Code Here
            /*if (age > 21)
             {
                 // body here
             }

             if (status == 2)
             {
                 // body here
             }
             */
            #endregion

            #region Clean Code Here
            /*const int legalDrinkingAge = 21;
            if (age > legalDrinkingAge)
            {
                // body here
            }

            if (status == Status.active)
            {
                // body here
            }
            */
            #endregion

            #endregion

            #region Complex Conditionals

            #region Intermediate Variables

            #region Dirty Code Here
            /*if (employee.Age > 55
                && employee.YearsEmployed > 10 && employee.IsRetired == true)
            {
                // body here
            }
            */
            #endregion

            #region Clean Code Here
            /*bool eligibleForPension = employee.Age > 55
                && employee.YearsEmployed > 10
                && employee.IsRetired == true;
            */
            #endregion

            #endregion

            #endregion

            #region Encapsulate Complex Conditionals

            #region Dirty Code Here
            /*//Check for valid file extensions, confirm is admin or active 
             * if ( (fileExt == ".mp4"
               | fileExt == ".mpg"
               || fileExt == ".avi")
               && (isAdmin == 1 || isActiveFile))
            */
            #endregion

            #region Clean Code Here
            /*
             * private bool ValidFileRequest(string fileExtension, bool isActiveFile, bool isAdmin)
            {
                return (fileExt == ".mp4"
                || fileExt == ".mpg"
                || fileExt == ".avi")
                && (isAdmin == 1 || isActiveFile))
            }
                */

            /*
             * private bool ValidFileRequest(string fileExtension, bool isActiveFile, bool isAdmin)
             * {
            * var validFileExtensions = new List<string>() { "mp4", "mpg", "avi" };
                bool validFileType = validFileExtensions.Contains(fileExtension);
                bool userIsAllowedToViewFile = isActiveFile || isAdmin;
                return validFileType && userIsAllowedToViewFile;
             * }
             * 
             */
            #endregion

            #endregion

            #region Favor Polymorphism Over Switch

            #region Dirty Code Here
            /*public void LoginUser(User user){
             * switch (user.Status){
             * case Status.Active:
               // active user logic
               break;
               case Status.Inactive:
               // inactive user logic 
               break;
               case Status.Locked:
               // locked user logic
               break;
              }
            }
            */
            #endregion

            #region Clean Code Here
            /*
             * public void LoginUser(User user)
             * {
             *   user.Login();
             * }
             * 
             * public abstract class User 
             * {
            *   public string FirstName; public string LastName; public int Status;
                public int AccountBalance;
                public abstract void Login();
             * }
            */

            /*
             * public class ActiveUser : User
             * {
             *  public override void Login()
             *  {
             *      //Active user logic here
             *  }
             * }
             * 
             * public class InactiveUser : User
             * {
             *  public override void Login()
             *  {
             *     //Inactive user logic here 
             *  }
             * }
             * 
             * public class LockedUser : User
             * {
             *  public override void Login()
             *  {
             *      //Locked user logic here
             *  }
             * }
             */
            #endregion

            #endregion

            #region Be Declarative

            #region Dirty Code Here
            /* List<User> matchingUsers = new List<User>();
            
            foreach (var user in users)
            {
                if (user.AccountBalance < minAccountBalance
                    && user.Status == Status.Active)
                {
                    matchingUsers.Add(user);

                }
            }
            */
            #endregion

            #region Clean Code Here
            /*
             * List<User> matchingUsers = new List<User>();
             * return users
             * Where(u => u.AccountBalance < minAccountBalance)
             * Where(u => u.Status == Status.Active);
             */
            #endregion

            #endregion

            #region Table Driven Methods

            #region Dirty Code Here
            /* if (age < 20)
             * return 345.60m;
             * else if (age < 30)
             * return 419.50m;
             * else if (age < 40)
             * return 476.38m;
             * else if (age < 50)
             * return 516.25m;
            */
            #endregion

            #region Clean Code Here
            /*
             * Insurance Rate Table
             * InsuranceRateId  MaximumAge  Rate
             * return Repository.GetInsuranceRate(age);
             * 
             * Examples
             * Insurance Rates
             * Pricing Structures
             * Complex and Dynamic business rules
             */
            #endregion

            #region Great for dynamic logic 

            #endregion

            #region Avoids hard coding 

            #endregion

            #region Write less code 

            #endregion

            #region Avoids complex data structures

            #endregion

            #region Make changes without a code deployment  

            #endregion

            #endregion

            #region Summary

            #region Strive for Clear Intent

            #endregion

            #region Assign & Compare Booleans Implicity

            #endregion

            #region Prefer Positive Conditional

            #endregion

            #region Prefer Ternary over if/else

            #endregion

            #region Be Strongly Typed via Constants,enums

            #endregion

            #region Avoid Magic Numbers

            #endregion

            #region Avoid Complex Conditionals
            //Declare Variables,Extract Methods

            #endregion

            #region Prefer Declarative over Imperative

            #endregion

            #region Consider Using the DB

            #endregion

            #endregion


        }
    }
}
