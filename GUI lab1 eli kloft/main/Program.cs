using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace main
{
    class Program
    {
        static int NumberItems = 10000;
        
        static void Main(string[] args)
        {
            int size = sizeof(uint);
            Console.WriteLine("The number of bits in an uint: {0}", size * 8);

            CreateFile();   //create file filled with 10k random numbers
            DateTime starttime = DateTime.Now;  //start the stopwatch
            int t;
            for (t = 0; t < 32; ++t)    //loop for 32 times, the number of bits in an uint
            {
                FileStream stream = new FileStream("rands.dat", FileMode.Open); //opens file
                BinaryReader origread = new BinaryReader(stream); //creates a binary reader
                FileStream stream2 = new FileStream("bucket1.dat", FileMode.OpenOrCreate, FileAccess.Write); //open the file
                stream2.SetLength(0);
                stream2.Position = 0;
                BinaryWriter write1 = new BinaryWriter(stream2); // creates the binary writer
                FileStream stream3 = new FileStream("bucket0.dat", FileMode.OpenOrCreate, FileAccess.Write); //open the file
                stream3.SetLength(0);
                stream3.Position = 0;
                BinaryWriter write0 = new BinaryWriter(stream3); //create the binary writer
                for (int i = 0; i < NumberItems; ++i)  //loop for 10k times, the amount of uints to be sorted
                {
                    uint num = TakeoffTop(origread); //takes the first number out off the top of the random pile

                    PutinBucket(num, t, write0, write1);//sends the number to be sorted and the current position to putinbucket
                }
                origread.Close();
                write0.Close();
                write1.Close();

                FileStream stream4 = new FileStream("rands.dat", FileMode.Open,FileAccess.Write); //opens file
                stream4.SetLength(0);
                stream4.Position = 0;
                BinaryWriter origwrite = new BinaryWriter(stream4);
                FileStream stream5 = new FileStream("bucket1.dat", FileMode.Open); //open the file
                BinaryReader read1 = new BinaryReader(stream5); // creates the binary writer
                FileStream stream6 = new FileStream("bucket0.dat", FileMode.Open); //open the file
                BinaryReader read0 = new BinaryReader(stream6); //create the binary writer*/

                PutBucketsBack(origwrite, read0, read1);   //take bucket1 and put back into random pile then bucket0
                origwrite.Close();
                read0.Close();
                read1.Close();

            }
            DateTime endtime = DateTime.Now; //stop the stopwatch
            
            TimeSpan timetaken = endtime.Subtract(starttime); //subtracting the 2 times
            Console.WriteLine("Sort took this much time ==> {0}", timetaken);
            if (IsCorrect()) //checks to see if the numbers are sorted correctly
            {
                Console.WriteLine("Looks like it sorted correctly!");
            }
            else
            {
                Console.WriteLine("Darn, it didnt sort correctly!");
            }
            
            Console.ReadLine(); // to make the program wait if you press ctrl f5
        }

        static void CreateFile()
        {
            Random random = new Random(); //creates a new random number generator
            FileStream orig = new FileStream("rands.dat", FileMode.Create); //creates rands.dat
            BinaryWriter writeorig = new BinaryWriter(orig); //creates a binary writer
            for (int i = 0; i < NumberItems; i++) //loop 10k times filling with random numbers
            {
                writeorig.Write((uint)random.Next());
            }
            writeorig.Close(); //always be sure to close the file when done with it
        }

        static uint TakeoffTop(BinaryReader read) //take the uint off the top of the random pile and returns it
        {
            uint num = 0;           
            num = (uint)read.ReadUInt32(); //reads the top number                        
            return num; //return
        }

        static bool IsCorrect() //checks to see if the numbers are in order
        {
            FileStream stream = new FileStream("rands.dat", FileMode.Open); //open the random file
            BinaryReader read = new BinaryReader(stream); //create a binary reader
            uint prev = 0;
            uint num = 0;
            bool isgood = true;
            for (int i = 0; i < NumberItems & isgood; i++) //check all 10k numbers or until not sorted
            {                
                num = (uint)read.ReadUInt32(); //reads a number
                if (num < prev) //checks to see if the numbers are being in order
                    isgood = false;
                prev = num; //check next number against the prev one
            }
            read.Close();   //close the file when done with it
            return isgood;
        }
        
        static void PutBucketsBack(BinaryWriter writeorig, BinaryReader readb0, BinaryReader readb1) //put bucket 0 and bucket 1 back into random pile
        {            
            uint num;            
            while (readb0.BaseStream.Position != readb0.BaseStream.Length)//checks to see if at EOF
            {
                num = (uint)readb0.ReadUInt32(); //reads the number
                writeorig.Write(num); //writes the number
                //writeorig.Flush();
            }            
            while (readb1.BaseStream.Position != readb1.BaseStream.Length)//check to see if at EOF
            {
                num = (uint)readb1.ReadUInt32(); //read the number
                writeorig.Write(num); //write the number
            }
        }

        static void PutinBucket(uint num, int pos, BinaryWriter write0, BinaryWriter write1) //takes a number and a position to look at and will put in correct bucket
        {
            if (IsBitSet(num, pos)) //checks to see if a bit is set
            {                             
                write1.Write(num); //writes the number                             
            }
            else
            {
                write0.Write(num); //write the number               
            }
        }

        static bool IsBitSet(uint num, int pos) //checks to see if a bit is set at a posisiton
        {
            long x = num & (1 << pos);
            return (num & (1 << pos)) != 0; //returns true if bit is set
        }
    }
}
