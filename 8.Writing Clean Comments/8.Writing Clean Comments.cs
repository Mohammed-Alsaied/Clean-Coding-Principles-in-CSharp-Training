namespace _8.Writing_Clean_Comments
{
    public class WritingCleanComments
    {

        #region Agenda
        /*
         * Comments: A necessity and a crutch 
         * Comments to avoid 
         * Useful comments 
         */
        #endregion

        #region Comments: A Necessity and a Crutch 
        /*
         * Prefer expressive code over comments 
         * Use comments when code isn't sufficient 
         */
        #endregion

        #region Comments to Avoid 
        /*
         * Redundant
         * Intent
         * Apology
         * Warning
         * Zombie Code
         * Divider 
         * Brace Tracker
         * Bloated Header
         * Defect Log 
         */
        #endregion

        #region Redundant Comments

        #region Dirty Code Here
        /*
         *  int i = 1; // Set i = 1
         
            var cory = new User(); //Instantiate a new user

            /// <summary>
            /// Default Constructor
            /// </summary>
            public User()
            {
            }

            /// <summary>
            /// Calculates Total Charges
            /// </summary>
            private void CalculateTotalCharges()
            {
            //Total charges calculated here
            }
         */
        #endregion

        #region 2 Rules to avoid Redundant Comments
        /*
         * Assume your reader can read code.
         * Donot Repeat yourself (DRY).
         */
        #endregion

        #endregion

        #region Intent Comments

        #region Dirty Code Here
        /*
            // Assure user’s account is deactivated. 
            if (user.Status == 2)
         */
        #endregion

        #region Clean Code Here
        /*
         * if (user.Status == Status.Inactive)//use enum
         */
        #endregion

        #region Clarify Intent without Comment
        /*
         * Improve function name
         * Declare Intermediate variables
         * Declare a constant or enum
         * Extract conditional to function
         */
        #endregion

        #endregion

        #region Apology Comments

        #region Dirty Code Here
        /*
         * // Sorry, this crashes sometimes so I'm swallowing the exception.
         * // I was too tired to refactor this pile when I was done...
         */
        #endregion

        #region Solution
        /*
         * Donot apologize
         * Fix it before commit/merge
         * Add a TODO marker comment if you mast
         */

        #endregion

        #endregion

        #region Warning Comments

        #region Dirty Code Here
        /*
         * // Here be dragons - see Bob
         * // Great sins against code below...
         */
        #endregion

        #endregion

        #region Zombie Code Comments

        #region Dirty Code Here
        /*
         * protected void Page_load(object sender, EventArgs e) 
            { 
                if (!IsPostBack)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "maps", "initialize();", true); 
                    addressl.Value = Request.QueryString["z"]; 
                    txtEstDistance.Visible = true;
                } 
                    if (!Page.IsPostBack) 
                    { imgbtnBinManagerGreen.Visible = false; 
                    imgbtnBinCheckGreen.Visible = false; 
                    imgbtnBinManagerBasicGreen.Visible = false; 
                    SetNewCustomerID(); 
                }
             
                I IHttpl􀀦ebRequest request = l􀀦ebRequest. Create("http: //api. hos tip. info/get json. php") as Http 􀀳ebRequest; I 
                //WebResponse response = request. GetResponse(); 
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ZipCode)); 
                //ZipCode zip = serializer.ReadObject(response.GetResponseStream()) as ZipCode; 

                //addressl.Value = "64064"; 
                //addressl.Value = zip.country_name;
                //Labell.Text = ipaddress; 

            {

                Ill <summary> 
                /// If an existing customer is selected on the previous step, then NewCustomerID = 0. 
                /// It needs to have a value since it's referenced "'hen creating the quote. So set the NewCustomerID /// to the UserID sent in the querystring 
                /// </summary> 
                private void SetNewCustomerID() 
                { 
                    SessionHelper.Ne..,CustomerID = Convert.Toint32(Request.QueryString["uid"]); 
                }
                //protected void LinkButtonl_Click(object sender, EventArgs e) 
                //{ 
                //Page. ClientScript. RegisterStartupScript(this. GetType(), "maps", "initialize();", true); txtBoxEnterZip.Visible = false; 
                //txtEstDistance.Visible = true; 
                //lnkbtnGetZip.Visible = false; 
                //addressl.Value = txtBoxEnterZip.Text; 
                //}
            

         */
        #endregion

        #region Common Causes 
        /*
         * Risk Aversion 
         * Hoarding mentality 
         */
        #endregion

        #region Optimize the Signal to N 01se Ratio  
        /*
         * We wouldn't stand for this. 
         */
        #endregion

        #region Ambiguity Hinders Debugging 
        /*
         * What did this section do? 
         * Was this accidentally commented? 
         * Who did this? 
         * Do I need to refactor this too? 
         * How does my change impact this code? 
         * What if someone uncomments it later? 
         */
        #endregion

        #region Kill Zombie Code 
        /*
         * Reduces readability 
         * Creates ambiguity 
         * Hinders refactoring 
         * Adds noise to searches 
         * Code isn't "lost" anyway 
         */
        #endregion

        #region Kill Zombie Code Checklist 
        /*
         * About to comment out code? Ask: 
         * When would this be uncommented? 
         * Can I just get it from source control later? 
         * Is this incomplete work that should be worked via a branch? 
         * Should this be toggled via configuration? 
         * Did I refactor out the need for this code? 
         */
        #endregion

        #endregion

        #region Divider Comments

        #region Dirty Code Here
        /*
         *private void MyLongFunction()
         *{
         *  // lots
         *  // of
         *  // code
            // Start search for available concert tickets
            // lots
            // of
            // concert
            // search
            // code
            // End of concert ticket search
            // lots
            // more
            // code
          }
         */
        #endregion

        #region Solution
        /*
         * Devide a long function to many function
         */
        #endregion

        #endregion

        #region Brace Tracker Comments

        #region Dirty Code Here
        /*
         private void AuthenticateUsers()
        {
            bool validLogin = false; 
            //deeply
            //nested
            //code
            if (validLogin)
        {
            // lots 
            // of 
            // code 
            // here 
        }   // end user login 
            //even
            //more code
        }
         */
        #endregion

        #region Clean Code Here
        /*
         * private void AuthenticateUsers()
         * {
         *  bool validLogin = false; .
         *  //deeply
         *  //nested
         *  //code
            if (validLogin)
            LoginUser(); }
            //even
            //more code{
        }
         */
        #endregion

        #region Solution
        /*
         *Enhances Redability
         *Reduces cyclomatic complexity
         */
        #endregion

        #endregion

        #region Bloated Header Comments

        #region Dirty Code Here
        /*
         //*************************************************** 
        // Filename: Monolith.cs *
        // 
        // Author: Cory House    
        // Created: 12/20/2019*
        // Weather that day: Patchy fog, then snow          *
        //                                                  *
        // Summary                                          *
        // This class does a great many things. To make it  *
        // extra useful I placed pretty much all the app    *
        // logic here. You wish your class was this         *
        // powerful. Bwahhahha!                             * 
        //***************************************************
         */
        #endregion



        #region Solution
        /*
         * Avoid line ending
         * Donot repeat yourself
         * Follow Conventions
         */
        #endregion

        #endregion

        #region Defect Log  Comments

        #region Dirty Code Here
        /*
             // Defect #5274 DA 12/10/2010
            // We weren't checking for null here if (firstName != null)
            {
                //...
            }
         */
        #endregion

        #region Solution
        /*
         * Change metadata belongs in source control
         * A well written book insnot covered in author notes
         */
        #endregion

        #endregion

        #region Clean Comments 

        #region To Do 

        #region Clean Code Here
        /*
         * // TODO Refactor out duplication.
         * // HACK The API doesn't expose needed call yet.
         */
        #endregion

        #region Solutions when not use VS IDE
        /*
         * Standadize
         * Watch out:
         * May be An abology or warning comment in disguise
         * Often ignored
         */
        #endregion

        #endregion

        #region Summary 

        #region Clean Code Here
        /*
         * // Encapsulates logic for calculating retiree benefits.
         * // Generates custom newsletter emails.
         */
        #endregion

        /*
         * Describes intent at general level higher than the code.
         * Often useful to provide high level overview of classes.
         * Risk: Donot use a simply augment poor naming/code level intent.
         */
        #endregion

        #region Documentation

        #region Clean Code Here
        /*
         * // See microsoft.com/api for documentation
         */
        #endregion

        /*
         * Useful when it canot be expressed in code as third party. 
         */
        #endregion

        #endregion

        #region About to Write a Comment
        /*
         * Comment are useful,but generally a last resort.
         * Ask:
         * 1.Could i express what iam about to type in code?
         *  intermediate variables,eliminate magic numbers,utilize enum?
         * Refactor to well named methode
             * Seperate Scope
             * More likely to stay updated
             * Better teastability
           2. Am i explaning bad code i just wrote instead of refactoring?
           3. Should this be a source control commit message?
         */
        #endregion

        #region Summary
        /*
         * Comments: A nessary and a crutch
         * Goal: Seld-documented code
         * Try to convey intent without comments
         * Avoid:
             * Redundant
             * Intent
             * Apology
             * Warning
             * Zombie Code
             * Divider 
             * Brace Tracker
             * Bloated Header
             * Defect Log 
            Clean 
             * To Do
             * Summary
             * Documentation
         */
        #endregion

    }
}