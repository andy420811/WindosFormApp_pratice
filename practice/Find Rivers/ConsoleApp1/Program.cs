using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int width,length;
            y = Int32.Parse(Console.ReadLine());
            x = Int32.Parse(Console.ReadLine());
            width = x+2;
            length = y+2;
            int[] bitmap = new int[(width) * (length)];
            int[] check  = new int[(width) * (length)];
            int count_river = 0;
            ReadStream(ref bitmap,width,length);    //+2 boundary
            BuildMap(ref check,width,length);
            
            count_river = SearchRiver(ref bitmap,ref check,width,length,0);
            
            Console.WriteLine("rivercount = "+ count_river);
        //    prtmap(ref check,width,length);
        //    prtmap(ref bitmap, width, length);
            Console.ReadKey();
        }
        private static int CheckIsRiver(ref int[] map,int map_pos)
        {
            if (map[map_pos] == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static int SearchRiver(ref int[] map,ref int[] check_map,int width,int length,int Ncheck_index){
            int RiverCount = 0;

            while((Ncheck_index = Array.IndexOf(check_map,0)) != -1){
         //   prtmap(ref check_map,width,length);
                if(CheckArround(ref map,ref check_map,width,length,Ncheck_index)==1)
                RiverCount++;
            }
            return RiverCount;
            
        }
        private static int CheckArround(ref int[] map,ref int[] check_map,int width,int length,int Ncheck_index){
        //    prtmap(ref check_map,width,length);
            if(check_map[Ncheck_index] == 1 || check_map[Ncheck_index] == -1){
                return 0;
            }
            else{
            check_map[Ncheck_index] = 1;
         //   prtmap(ref check_map,width,length);
              if(map[Ncheck_index] == 1 ){
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index-width);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index-width-1);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index-width+1);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index-1);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index+1);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index+width-1);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index+width);
                   CheckArround(ref map,ref check_map,width,length,Ncheck_index+width+1);
                   return 1;
               }else if(map[Ncheck_index] == 0){
                    check_map[Ncheck_index] = 1;
                    return 0;
                }else return 0;
            }
        }
        private static bool Stop(ref int[] check_map,int width,int length,int Ncheck_index){
            if(Ncheck_index/width == 0 || Ncheck_index/width == length-1 || Ncheck_index%width == 0 || Ncheck_index %width == width -1)return true;
            if((check_map[Ncheck_index-width]&
               check_map[Ncheck_index-width-1]&
               check_map[Ncheck_index-width+1]&
               check_map[Ncheck_index-1]&
               check_map[Ncheck_index+1]&
               check_map[Ncheck_index+width-1]&
               check_map[Ncheck_index+width]&
               check_map[Ncheck_index+width+1]&1) == 1){
                return true;
            }
            else{
                return false;
            }
                

        }

        private static void prtmap(ref int[] map,int width,int length)
        {
            for(int i = 0; i < map.Length; i++)
            {
                
                Console.Write(map[i]);
                if ((i+1)%width==0) Console.Write("\n");
            }
        }
        private static void BuildMap(ref int[] map,int width,int length)
        {
            for(int i=0;i<map.Length;i++){
                if(i % width == 0 || i % width == width -1 || i/width == 0 || i/width == length-1 ){
                map[i] = - 1;
                }
            }

        }
        private static void prtStream(ref int[] map,int width, int length)
        {
            for (int i = 0; i < width*length; i++)
            {

                if (map[i] == 0)
                {
                    Console.Write("*");
                }
                else Console.Write("#");
                if ((i + 1) % width == 0) Console.Write("\n");
            }
        }
        private static void ReadStream(ref int[] map,int width,int length){
            string read = "";
            for(int i=0;i<length-2;i++){
                 read += Console.ReadLine();
            }
            int pos = 0;
            for(int i=0;i<map.Length;i++){
                if(i % width == 0 || i % width == width -1 || i/width == 0 || i/width == length-1 ){
                map[i] = - 1;
                }else  {
                    getRead(ref map,read,ref pos,i);
                    pos++;
                }
            }
        }
        private static void getRead(ref int[] map, string read,ref int pos,int map_pos){
            bool check = false;
            while(check == false){
                if(read[pos] == '*'){
                    map[map_pos] = 0;
                    check = true;
                }else if(read[pos] == '#'){
                    map[map_pos] = 1;
                    check =true;
                }else{
                    continue;
                }
            }
        }
    }
}
