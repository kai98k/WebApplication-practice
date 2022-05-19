using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class HW2Controller : Controller
    {


//        1.	質數判斷(必須用回圈，不得使用陣列)
//請宣告一個整數變數，值由參數傳入，並判斷其是否為質數，若是，請在螢幕顯示「○○是質數」，若不是，請在螢幕顯示「○○不是質數」。如例變數值為13，即顯示「13是質數」。(ps.質數的定義為除了1與本身之外，沒有其他的因數存在)

     public string No1 (int n)
        {


            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return n + "不是質數";
                }
            }
            return n + "是質數";
        }


     public string No2 (int n,int m)
        {
            int M = m, N = n;
            int z = 0; //這個數放餘數

            while(M % N != 0)
            {
               z= M % N;  
               M = N;
               N = z;
            }
            return m+"與"+n+"之最大公因數為"+N;
        }
     public string No3 (int n)
        {
            int N = n, result = 0;
            int q = 0, r = 0; //q放商 r放餘數
            do
            {
                r = N % 10;  
                q = N / 10;     
                N = q;         

                result = result * 10;
                result = result + r;
            } while (q != 0);

            if (n == result)
                return n + "是迴文";

            return n + "不是迴文";
        }
    }

}