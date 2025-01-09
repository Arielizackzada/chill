namespace QLab;
public class Program
// אריאל יהודה יצחק זדה

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Queue<int> q = new Queue<int>();
        q.Insert(7);
        q.Insert(10);
        q.Insert(3);
        Console.WriteLine(q);
        Queue<int> qCopy = SetQCopy(q);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        q.Insert(17);
        qCopy.Insert(13);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);

        bool isIn = IfNumInQ(q,3);
        Console.WriteLine(isIn);
    }
    public static bool IfNumInQ(Queue<int> q,int num) 
    // הפונקציה מחזירה אם המספר נמצא בתור
    {
        int ezer = 0;
        bool numInQ = false;
        Queue<int> qCopy = SetQCopy(q);
        while (!qCopy.IsEmpty()) 
        {
            ezer = qCopy.Remove();
            if (num == ezer) 
            {
                numInQ =  true;
            }
        }
        return numInQ;
    }

    public static Queue<int> SetQCopy(Queue<int> q)
    {
        Queue<int> qCopy = new();
        Queue<int> qTemp = new();
        int currItem;
        //פריקת התור המקורי ויצירת תור העתק ותור זמני
        while (!q.IsEmpty())
        {
            currItem = q.Remove();
            qTemp.Insert(currItem);
            qCopy.Insert(currItem);
        }
        //שחזור התור המקורי
        while (!qTemp.IsEmpty())
        {
            q.Insert(qTemp.Remove());
        }
        return qCopy;
    }
        

}