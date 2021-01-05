using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTnhom
{
    class book_sales
    {       
        
        //cout bill
        public double bill_invoid(int book_num, int is_student)
        {           
            double total = 0;               
            total = book_num * 20000;
            total -= total * is_student * 0.05;
            return (total);
        }

        //cout statistics
        
    }
}
