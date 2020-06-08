using System;

public class lib1
{
    static public string Stpow(string a, int b)
    {

        string n = "";
        for (int i = 0; i < b; i++)
        {
            n = n + a;
        }
        return n;

    }
    static public string Rev(string c)
    {
        char[] m = c.ToCharArray();
        string r = String.Empty;
        for (int i = m.Length - 1; i > -1; i--)
        {
            r += m[i];
        }
        return r;
    }
    static public string remov (string ki, string ho)
    {
      if (ki.Contains(ho))
        {
            ki = ki.Replace(ho, "");
        }
        return ki;

    }
    static public int leng(string str)
    {

        return str.Length;

    }


}
