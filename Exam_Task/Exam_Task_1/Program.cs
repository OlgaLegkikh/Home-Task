// See https://aka.ms/new-console-template for more information
using System.Text;

StringBuilder str = new StringBuilder();
int[,,] mas = { { { 1, 2 },{ 3, 4 } },
{ { 4, 5 }, { 6, 7 } },
{ { 7, 8 }, { 9, 10 } },
{ { 10, 11 }, { 12, 13 } }
};

str.Append("{");
for (int n = mas.GetLowerBound(0); n <= mas.GetUpperBound(0);
     n++)
{

    for (int j = mas.GetLowerBound(1); j <= mas.GetUpperBound(1);
         j++)
    {
        str.Append("{");

        
        for (int i = mas.GetLowerBound(2); i <= mas.GetUpperBound(2); i++)
        {
            if (i == 0)
            {

                str.Append("{");
                str.Append(mas.GetValue(n, j, i));
                str.Append(",");
            }
            else
            {
                str.Append(mas.GetValue(n, j, i));
                str.Append("}");
            }
            
          
        }
        if (j != mas.GetUpperBound(1))
        {
            str.Append(",");
        }
        else
        {
            str.Append("}");
        }

    }
    if (n != mas.GetUpperBound(0))
    {
        str.Append(",");
    }


}
str.Append("}");
Console.WriteLine(str.ToString());