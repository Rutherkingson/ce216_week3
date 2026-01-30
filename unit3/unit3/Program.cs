namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            //ตั้งค่าencodingเพื่อรองรับภาษาไทย
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("ตัวอย่างที่4.1: ตรวจสอบเลขบวก/ลบ/และคู่/คี่");

            Console.Write($"ตัวเลข:");
            string value = Console.ReadLine();
            int valueinput = int.Parse(value);

            if (valueinput > 0)
            {
                Console.WriteLine("-เป็นจำนวนบวก");
                if (valueinput % 2 == 0)
                {
                    Console.WriteLine("-และเป็นเลขคู่");
                }
                else
                {
                    Console.WriteLine("-และเป็นเลขคี่");
                }
            }
            else if (valueinput < 0)
            {
                Console.WriteLine("-เป็นจำนวนลบ");
            }
            else
            {
                Console.WriteLine("-เป็นศูนย์");
            }
            
        }
    }
}
