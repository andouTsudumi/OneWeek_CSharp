
// hello worldをコンソールに表示する方法.

/*
 * ステートメント
 * usingの後に続くのは名前空間であり、指定した名前空間を使用するという意味になる
 * includeだね！
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 同じネームスペースには同じ名前のクラスが存在してはいけない
 * 逆に言うとネームスペースが異なれば同じ名前のクラスが存在しても構わない
 * 
 * ファイルが増えた分はファイルパスをnamespaceに書いておくとよし.
 */
namespace OneWeek.basic.basic1day
{
    class basic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
        }
    }
}