namespace _7.Writing_Clean_Classes
{
    public class WritingCleanClasses
    {

        #region Agenda
        /*
         * Classes are like book Headings
         * when to create a class
         * Measuring Quality (Cohesion,Name,Size)
         * Primitive Obsession
         * Proximity Principles
         * Outline Rule
         */
        #endregion

        #region When To Create a Class 
        /*
         * New concept           -> Abstract or real-world 
         * Low Cohesion          -> Methods should relate  
         * Promote Reuse         -> Small, targeted => reuse  
         * Reduce complexity     -> Solve once, hide away  
         * Clarify parameters    -> Identify a group of data  
         */
        #endregion

        #region Class Responsibilities Should Be Strongly-related
        /*
         * Enhances Readability
         * Increase Likelihood of reuse
         * Avoid Attracting the lazy
         * Watch for:
         *  Standalone Methods
         *  Field used by inly one method
         *  Classes that change often
         */
        #endregion

        #region Low VS High Cohesion

        #region Low Cohesion
        /*
         * Edit vehicle options
         * Update pricing
         * Schedule maintenance
         * Send maintenance reminder
         * Select financing
         * Calculate monthly payment
         */
        #endregion

        #region High Cohesion
        /*
         * class Vehicle
             * Edit vehicle options
             * Update pricing
         * class VehicleMaintenance
            * Schedule maintenance
            * Send maintenance reminder
         * class VehicleFinance 
            * Select financing
            * Calculate monthly payment
         */
        #endregion

        #endregion

        #region Broad Names Lead to Poor Cohesion 
        /*
         * Website BO 
         * Utility 
         * Common 
         * MyFunctions 
         * JimmysObjects
         * Manager
         * Processor
         * Info
         Specific names lead to smaller more cohesive classes 
         */
        #endregion

        #region Deep Thoughts
        /*
         * Ever Complain that a class is too small? (itis rare)
         * Signs itis to small
         * Inapprotiate Intimacy
         * Feature Envy
         * Too Many Pieces
         */

        #endregion

        #region Primitive Obsession

        #region Dirty Code Here
        /*
         * private void SaveUser(string firstName, string lastName,
         * string state, string zip, string eyeColor, 
         * string phone, string fax, string maidenName)
         */
        #endregion

        #region Clean Code Here
        //private void SaveUser(User user)

        #endregion

        /*
         * Helps reader Conseptualize
         * Implicit -> Explicit
         * Encapsulation
         * Aids Maintenance
         * Easy to find a references
         */
        #endregion

        #region Proximity Principles
        /*
         * Make code read top to bottom when possible. Keep related actions together. 
           private void ValidateRegistration() 
           {
                ValidateData (); 
                if (!SpeakerMeetsOurRequirements()) 
                { 
                throw new SpeakerDoesntMeetRequirementsException("This speaker doesn't meet our standards."); } 
                ApproveSessions(); 
           }
        private void ValidateData() 
        {
            if (string.IsNullOrEmpty(FirstName)) throw new ArgumentNullException("First Name is required."); 
            if (string.IsNullOrEmpty(LastName)) throw new ArgumentNullException("Last Name is required."); 
            if (string.IsNullOrEmpty(Email)) throw new ArgumentNullException("Email is required."); 
            if (Sessions. Count() == 0) throw new Argument Exception( "Can't register speaker with no sessions to present.");
        }
        private bool SpeakerMeetsOurRequirements() 
        {
            return IsExceptionalOnPaper() 11 ! Obvious Red Flags(); 
        }

         */
        #endregion

        #region The Outline Rule 
        /* Collapsed code should read like an outline
         * Consider creating multiple layers of abstraction 
         */

        #region Dirty Code Here
        /*
         *  Method 1
         *   Method 1a 
         *     Method 1 ai 
         *     Method 1 aii 
         *     Method 1 a iii
         *   Method 1 b 
         *   Method 1c   
         */
        #endregion

        #region Clean Code Here
        /*
         * Method 1
         *  Method 1a 
         *   Method 1 ai 
         *   Method 1 aii 
         *  Method 1 b
         *   Method 1 bi 
         *   Method 1 bii
         *  Method 1c
         * Method 2 
         *  Method 2a 
         *  Method 2b 
         * Method 3 
         *  Method 3a 
         *  Method 3b
         */
        #endregion
        #endregion


    }
}