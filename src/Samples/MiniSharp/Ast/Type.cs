﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.MiniSharp.Ast
{
    public abstract class Type : AstNode
    {
        public TypeBase ResolvedType { get; set; }
    }
}
