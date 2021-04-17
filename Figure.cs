using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Csharp
{
    public class Figure
    {

         protected List<Point> pList;
           public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}