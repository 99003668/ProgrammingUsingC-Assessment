using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport:Employee
    {
        private object p;
        private string v;
        private static String eName;
        private static int eLevel;
        private static DateTime eDoJ;

        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }
        public static int eID { get; }

        //public DirectReport(int l, DateTime doj, int diff)

        public DirectReport(Employee managerEmpObj,string pCode) :base(eID,eName,eLevel,eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, object p, string v) : base(eID, eName, eLevel, eDoJ)
        {
            this.p = p;
            this.v = v;
        }
    }
}
