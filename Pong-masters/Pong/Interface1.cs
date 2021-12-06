using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    interface Interface1
    {
        bool ProcessMove(); //움직임 관련
        int DoMove(); //ProcessMove() 도움을 주는 메소드
    }
}
