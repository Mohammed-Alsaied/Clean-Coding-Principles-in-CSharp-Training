namespace _6.Writing_Clean_Methods
{
    public class WritingCleanMethods
    {
        #region Agenda
        /*
            High signal functions
            When to create a function
            Techniques to maintain simplicity 
            Approaches to minimize variable lifetime 
            Signs a function is too long
            Exceptions and error handling         
         */
        #endregion

        #region Function vs Method
        /*
         * Both functions and methods are pieces of code, called by name. 
         * Core difference: Methods are associated with an object.
         */
        #endregion

        #region When To Create a Function
        /*
         * Avoid Duplication
         * Indentation
         * Unclear intent
         * > 1 task
         */
        #region Avoid Duplication
        /*
        * Key: Don’t repeat yourself
        * Code is a liability
        * Less is more
        */
        #endregion

        #region Excessive Indentation: Arrow Code
        /*
         * Comprehension decreases beyond three levels of nested 'if' blocks. Study by Noam Chomsky and Gerald Weinberg
         */

        #region Excessive Indentation: Solutions
        /*
         *  Extract Method 
         *  Fail Fast 
         *  Return Early         
         */

        #region Extract Method

        #region Dirty Code Here
        /*
          if
               if
                   while
                       do
                       some      
                       complicated 
                       thing
                   end while
               endif
          endif 
        */
        #endregion

        #region Clean Code Here
        /*
          if
               if
                   doComplicatedThing()
               endif
          endif 

        doComplicatedThing()
        {
            while
            do some complicated thing end while
        }
        */
        #endregion

        #endregion

        #region Fail Fast

        #region Dirty Code Here
        /*
          public void RegisterUser(string username, string password) 
        {
          if (!string.isNullOrWhitespace(username)) 
            {
                  if (!string.isNullOrWhitespace(password)) { 
                    // register user
                } else {
                    throw new ArgumentException("Username is required."); 
                }
                throw new ArgumentException("Password is required.");
            }
        }
        */
        #endregion

        #region Clean Code Here
        /*
          public void RegisterUser(string username, string password) {
            if (string.isNullOrWhitespace(username)) {
                throw new ArgumentException("Username is required."); Guard Clauses
            }
            if (!string.isNullOrWhitespace(password)) { 
                throw new ArgumentException("Password is required."); 
            }
                // register user
        }


        public void LoginUser(User user)
        {
            switch (user.Status)
            {
                case Status.Active:
                //logic for active users break;
                case Status.Inactive:
                //logic for inactive users 
                break;
                case Status.Locked:
                //logic for locked users 
                break;
                default: 
                throw new ApplicationException("Unknown status: " + user.Status);
            }
        }
        */
        #endregion

        #endregion

        #region Return Early

        #region Dirty Code Here
        /*
          private bool ValidUsername(string username)
        {
            bool isValid = false;
            const int MinUsernameLength = 6;
            if (username.Length >= MinUsernameLength)
            {
                const int MaxUsernameLength = 25;
                if (username.Length <= MaxUsernameLength)
                {
                    bool isAlphaNumeric = username.All(Char.IsLetterOrDigit); 
                    if (isAlphaNumeric)
                    {
                        if (!ContainsCurseWords(username))
                        {
                            isValid = IsUniqueUsername(username);
                        }
                    }
                }
            }
            return isValid;
        }           
        */
        #endregion

        #region Clean Code Here
        /*
          private bool ValidUsername(string username)
        {
            const int MinUsernameLength = 6;
            if (username.Length < MinUsernameLength) return false;
            const int MaxUsernameLength = 25;
            if (username.Length > MaxUsernameLength) return false;
            bool isAlphaNumeric = username.All(Char.IsLetterOrDigit); if (!isAlphaNumeric) return false;
            if (ContainsCurseWords(username)) return false;
            return IsUniqueUsername(username); 
        }
        */
        #endregion

        #endregion


        #endregion
        #endregion

        #region Convey Intent

        #region Dirty Code Here
        /*
         //Check for valid file extensions, confirm is admin or active
        if ( (fileExt == ".mp4" || fileExt == ".mpg" || fileExt == ".avi") &&
        (isAdmin == 1 || isActiveFile))
        */
        #endregion

        #region Clean Code Here
        /*
         private bool ValidFileRequest(string fileExtension, bool isActiveFile, bool isAdmin)
        {
            var validFileExtensions = new List<string>() { "mp4", "mpg", "avi" };
            bool validFileType = validFileExtensions.Contains(fileExtension); bool userIsAllowedToViewFile = isActiveFile || isAdmin;
            return validFileType && userIsAllowedToViewFile;
        }
        */
        #endregion

        #endregion

        #region Do One Thing
        /*
         * Aids the reader
         * Promotes reuse
         * Eases naming and testing
         * Avoids side-effects
         */
        #endregion

        #endregion

        #region Mayfly Variables

        #region Dirty Code Here (Inialize all variables in the top)
        /*
         * private void Mayfly()
         * {
        *   bool a = false;
            int b = 0;
            string c = string.Empty; bool d = true;
            //body continues
            //...
            a = SomethingIsTrue();
            if (a)
            {
                if (c.Length > b)
                {
                    //body continues
                    //...
                    d = c.Substring(0, 3) == b.ToString();
                }
            }
           }
         */
        #endregion

        #region Mayfly variable recipe
        /*
         *  1.Initialize variables just-in-time
         *  2.Do one thing
         */
        #endregion

        #endregion

        #region How Many Parameters? (Strive to 1-2 Parameters)

        #region Dirty Code Here
        /*
         * public void SaveUser(User user,bool sendMail,int emailFormat,
         * bool printReport,bool sendBill)
         * 
         * private void SaveUser(User user, bool emailUser) Avoid Flag Arguments
         * {
         *      //save user here, then…he function is doing two things.
                if (emailUser)
                {
                    //email user
                }
            }
         */
        #endregion

        #region Clean Code Here
        /*
         * public void SaveUser(User user)
         * 
         * private void SaveUser(User user)
         * {
         *      //save user
         * }
         * 
         * private void EmailUser(User user)
         * {
         *      //email user
         * }
         */
        #endregion

        #endregion

        #region Signs It’s Too Long
        /*
         * Whitespace & Comments
         * Scrolling required
         * Naming issues
         * Multiple Conditionals
         * Hard to digest
         * 
         * Rarely be over 20 lines Rarely over 3 parameters
         * Simple functions can be longer. Complex functions should be short.
         */
        #endregion

        #region Exception Types

        #region Unrecoverable
        /*
         * Null reference
         * File not found
         * Access denied
        */
        #endregion

        #region Recoverable
        /*
         * Retry connection
         * Try different file
         * Wait and try again
        */
        #endregion

        #region Ignorable
        /*
         * Logging click

       */
        #endregion

        #region Try/Catch/Log = Fail Slow

        #region Dirty Code Here
        /*
         * try
         * {
         *  RegisterSpeaker();
         * }
         *  catch(Exception e)
         * {
         *  LogError(e)
         * }
         * EmailSpeaker();
         */

        #endregion

        #region Clean Code Here
        /*
         * RegisterSpeaker(); 
         * EmailSpeaker();
         */
        #endregion
        #endregion

        #region Try/Catch Body Standalone

        #region Dirty Code Here
        /*
         * try
         * {
         *  // many lines
            // of complicated 
            // logic here
            }
            catch(Exception e)
        {
            // do something here
        }
         */
        #endregion

        #region Clean Code Here
        /*
         * try
         * {
         *  SaveThePlanet();
         * }
         * catch (Exception e)
         * {
         * //do something here
         * }
         * 
         * private void SaveThePlanet()
         * {
         *  // many lines
            // of complicated 
            // logic here
        }
         */

        #endregion
        #endregion

        #endregion

        #region Summary

        #region When to create a function
        /*
         *  Duplication 
         *  indentation
         *  unclear intent
         *  multiple tasks
         */
        #endregion

        #region Eliminate indentation
        /*
         * Extract method 
         * fail fast 
         * return early
         */
        #endregion

        #region Limit variable lifetime (Mayfly variables)

        #endregion

        #region Avoid boolean args

        #endregion

        #region Watch for signs the func is too long

        #endregion

        #region Avoid catching unrecoverable exceptions

        #endregion

        #endregion


    }
}