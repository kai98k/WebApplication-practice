using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class HW1Controller : Controller
    {
        public HW1Controller()
        {
            var abc = 123;
        }
        // GET: HW1
        public string No3(int X,int Y)
        {
            X = X + Y; 
            Y = X - Y; 
            X = X - Y;
            return "X=" + X+",Y="+Y;
        }
        public string No4(int? S)
        {
            int score = (int)S / 10;
            switch(score)
            {
                case 10:
                case 9:
                    return "優等";
                case 8:
                    return "甲等";
                case 7:
                    return "乙等";
                case 6:
                    return "丙等";
                default:
                    return "丁等";

            }    
        }
        public void No5(int N)
        {
           for (int i = 0;  i<= N;i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                else
                {
                    Response.Write(i + ",");
                }
            }
        }
        public void No6(int N)
        {
  
            int I = 0;
            for (int i = 0; i <= N; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    I += i;
                }
            }
            Response.Write(I);
        

        }
        public void No7(int N)
        {

            int i = 0;
            string star = "";
            while (i < N)
            {
                star += "*";
                Response.Write(star + "<br>");
                i++;
            }

        }
        public void No8()
        {
            int i = 1;
            int j = 1;
            int t;
            for (i = 1;i<10;i++)
            {
              for (j = 1; j<10; j++)
                {
                    t = i * j;
                    Response.Write(t + "=" + i + "*" + j +"、");
                }
                Response.Write("<hr>");
            } 
            
        }
    }
}