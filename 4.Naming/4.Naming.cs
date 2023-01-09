namespace _4.Naming
{
    public class Naming
    {
        #region Why is naming critical? 
        /*
         * Names to avoid 
         * Avoiding side-effects 
         * Selecting good variable names 
        */
        #endregion

        #region Naming Matters

        #region Dirty code here
        //List<decimal> p = new List<decimal>() { 5.50m, 1.48m };
        //decimal t = 0;
        //foreach (var i in p)
        //{
        //    t += i;
        //}
        //return t;

        #endregion

        #region Clean code here
        /*List<decimal> prices = new List<decimal>() { 5.50m, 1.48m }; decimal total = 0;
        foreach (var price in prices)
        {
            total += price;
        }
        return total;
        */
        #endregion

        #endregion

        #region Naming Classes

        #region Dirty code here
        /* 
         * WebsiteBO
         * Utility
         * Common
         * MyFunctions
         * JimmysUtils
         * *Manager/ *Processor/*lnfo
        */
        #endregion

        #region Clean code here
        /*
        *User 
        *Account
        *QueryBuilder
        *Product Repository
        */
        #endregion

        #region Specific names encourage small, cohesive classes 
        #endregion

        #endregion

        #region Class Naming Guidelines 
        /*
         * Noun
         * Be Specific
         * Single Responsibility 
         * Avoid generic suffixes 
         */

        #endregion

        #region The Method Name Says It All 

        #region Dirty code here
        /* Go
         * Complete
         * Get
         * Process
         * Dolt
         * Start
         * On_lnit, Page_Load, etc. 
        */
        #endregion

        #region Clean code here
        /*
        * GetRegisteredUsers
        * lsValidSubmission  
        * lmportDocument
        * SendEmail
        */
        #endregion

        #endregion

        #region Avoid Side Effects 
        /*
         * CheckPassword shouldn't log users out. 
         * ValidateSubmission shouldn't save. 
         * GetUser shouldn't create their session. 
         * ChargeCreditCard shouldn't send emails. 
         * Make sure methods names are comperhensive and tell the whole truth
         */

        #endregion

        #region Naming Warning Signs
        /*
         * And
         * If
         * Or
         * ProcessOrDeny
         * CalculateAndDisplay
         * you need to method not one
         */

        #endregion

        #region Avoid Abbreviations 
        /*
         * It's not the SO's
         * No standard 
         * We talk about code 
         * RegUsr
         * RegistUser
         * RegisUser
         * RegisterUser
         */

        #endregion

        #region Naming Variables:Booleans
        #region Dirty code here
        /* Open
         * Start
         * Status
         * Login
         * if (login) {}
        */
        #endregion

        #region Clean code here
        /*
        * isOpen
        * done  
        * isActive
        * LoggedIn
        * if (loggedIn) {}
        */
        #endregion

        #endregion

        #region Naming Variables:Be Symmetrical 

        #region Dirty code here
        /* on/disable
         * quick/slow
         * lock/open
         * slow/max 
        */
        #endregion

        #region Clean code here
        /*
        * on/off
        * fast/slow  
        * lock/unlock
        * min/max
        */
        #endregion

        #endregion

        #region Summary
        /*
         * The name should say it all 
         * Use specific class names
         * Watch for function side-effects
         * Avoid abbreviations 
         * Booleans should sound true/ false
         * Strive for symmetry
         * Verbalize when struggling
         */

        #endregion
    }
}