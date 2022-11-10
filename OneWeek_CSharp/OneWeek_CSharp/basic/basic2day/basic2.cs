
// 変数を使用した演算方法.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWeek.basic.basic2day
{
    class basic2
    {
        static void Main(string[] args)
        {
            int a;
            int b = 3;
            int add, sub;
            double avg;

            a = 6;
            add = a + b;
            sub = a - b;
            avg = (a + b) / 2.0f;

            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);

            /*
             * エラー：入力文字の形式が正しくありません。
             * Console.WriteLine("{0]と{1}の平均値{2}", a, b, avg);
             * これは0の右側が}ではなく]で入力していることによるエラーの発生である.
             */
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);

            /* ーーーーーーーーーーーーデータの型の種類
             * byte	    符号なし整数	                                             8	0 ～ 255
             *  sbyte	符号付き整数	                                             8	-128 ～ 127
             *  int	    符号付き整数	                                            32	-2,147,483,648 ～ 2,147,483,647
             *  uint	符号なし整数	                                            32	0 ～ 4294967295
             *  short	符号付き整数	                                            16	-32,768 ～ 32,767
             *  ushort	符号なし整数	                                            16	0 ～ 65535
             *  long	符号付き整数	                                            64	-922337203685477508 ～ 922337203685477507
             *  ulong	符号なし整数	                                            64	0 ～ 18446744073709551615
             *  float	単精度浮動小数点型	                                        32	-3.402823e38 ～ 3.402823e38
             *  double	倍精度浮動小数点型	                                        64	-1.79769313486232e308 ～ 1.79769313486232e308
             *  char	単一 Unicode 文字	                                        16	テキストで使用される Unicode 記号
             *  bool	論理ブール型	                                             8	True または False
             *  object	他のすべての型の基本型		
             *  string	文字列		
             *  decimal	29 の有効桁数で 10 進数を表現できる正確な小数または整数型  128	±1.0?×?10e ? 28 ～ ±7.9?×?10e28
             */
        }
    }
}
