using System;
using System.Security.Cryptography.X509Certificates;

namespace CodingTest.TestQuestions.Question2
{
    public class MatchingAlgorithm
    {
        /// <summary>
        /// A Customer is looking to match their contact list to their users.  We have a list of contacts and a listing of their
        /// active directory logins for each computer.  Unfortunately, over the years, they have had different models of how they create
        /// their active directory logins, and so our algorithm should be able to determine whether a username matches based on a few different
        /// patterns
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="activeDirectoryLogin"></param>
        /// <returns></returns>
        public bool IsMatch(string FirstName, string LastName, string activeDirectoryLogin)
        {
            throw new NotImplementedException();
            public class firstAlgo
        {
            var split = activeDirectoryLogin.Split('\\').last();
            
            //non active domain case handle
            if(split == null){ split = activeDirectoryLogin;

            //first initial & last name
            if(split.StartsWith(FirstName[0], StringComparison.OrdinalIgnoreCase) && split.Substring(1).Equals(LastName, StringComparison.OrdinalIgnoreCase)) {return true;}

            //firstname.lastname
            if (split.Equals($'{FirstName.ToLower() }.{LastName.ToLower() }', StringComparison.OridnalIgnoreCase)){return true;}       
 
            //FirstName.MiddleInitial.LastName ... this one confused me bcause the question doest say to assume theres a  middle initial.
            if (split.Equals($'{FirstName.ToLower()}.{MiddleInitial.ToLower()}.{LastName.ToLower()}', StringComparison.OrdinalIgnoreCase)){return true;}

                return false;
        }
        }
    public class Question
    } 
}
