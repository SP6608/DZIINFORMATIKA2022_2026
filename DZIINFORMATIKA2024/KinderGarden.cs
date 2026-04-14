using System;
using System.Collections.Generic;
using System.Text;

namespace DZIINFORMATIKA2024
{
    public class KinderGarden
    {
        private readonly List<Kid> kidList;
        public KinderGarden()
        {
            this.kidList = new List<Kid>();
        }
        //Methods of class
        public string EnrollKid(Kid kid)
        {
            kidList.Add(kid);
            return $"The child {kid.FirstName} {kid.LastName} is enrolled.";
        }//end 1
        public string ReleaseKid(string id) 
        {
            Kid? searchKid=kidList.FirstOrDefault(k => k.Id == id);
            if (searchKid != null) 
            { 
                kidList.Remove(searchKid);
                return $"The child {searchKid.FirstName} {searchKid.LastName} has been unsubscribed.";
            }
            return $"Unsubscribe failed - invalid identifier {id}.";
        }//end2
        public string GroupInfo(string group)
        {
            StringBuilder sb = new StringBuilder();
            int groupCount=kidList.Count(x=> x.Group == group);
            string groupInfo = $"{group} group - {groupCount} children.";
            sb.AppendLine(groupInfo);
            var kidsGroup=kidList.Where(x=> x.Group == group);
            foreach (var kid in kidsGroup) 
            {
                sb.AppendLine(kid.ToString());
            }
            return sb.ToString().Trim();
        }//end3
    }
}
