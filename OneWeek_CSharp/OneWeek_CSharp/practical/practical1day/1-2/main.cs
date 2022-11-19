using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 特定のインスタンスを消去することはできない
 * その代わりにガーベージコレクションという仕組みが存在
 * 時々メモリの中の不要なオブジェクトを整理してくれる
 */

namespace OneWeek.practical.practical1day._1_2
{
    class main
    {
        static void Main(string[] args)
        {
            string[] a = new String[10000];
            for(int i = 0;i<10000;i++)
            {
                // インスタンスの生成.
                a[i] = new String('M', 10000);
            }
            // GC.GetTotalMemory(false)でメモリ使用量の取得.
            Console.WriteLine("メモリ使用量(GC発動前)　：" + GC.GetTotalMemory(false));

            a = null;
            Console.WriteLine("メモリ使用量(参照解除後)：" + GC.GetTotalMemory(false));
            /*
             * ガーベージコレクションはどこで機能しているかはわからない 
             * ユーザー側からガーベージコレクションを起動することは可能
             * 
             * ガーベージコレクションはどんなオブジェクトも参照していない状態であるもの
             * つまりメモリ内に存在はしているが使用されない状態にあるデータを自動的に消去してくれる
             * 
             * しかしガーベージコレクションがどのタイミングで呼び出されるのかはわからないので
             * GC.Collect()で強制的に呼び出している
             */
            GC.Collect();//@@@

            /*
             * newによってインスタンスなどが生成されるメモリ領域のことをヒープという
             * ヒープに生成されるオブジェクトはその生成機関に応じて種類ごとにわけられている
             * 
             * その分類方法をジェネレーションという
             * ジェネレーションはオブジェクトの生存期間の短いものから０～２の３種類に分かれている
             * この種類番号は動的に切り替えられる
             * 
             * 特定のジェネレーションのデータに対してガーベージコレクションを発動させることが出来る
             */

            Console.WriteLine("メモリ使用量(GC発動後)　：" + GC.GetTotalMemory(false));
        }
    }
}
