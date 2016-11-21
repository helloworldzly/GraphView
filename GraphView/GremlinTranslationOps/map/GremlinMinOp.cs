﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphView.GremlinTranslationOps.map
{
    internal class GremlinMinOp: GremlinTranslationOperator
    {
        public Scope Scope;
        public GremlinMinOp() { }

        public GremlinMinOp(Scope scope)
        {
            Scope = scope;
        }
        public override GremlinToSqlContext GetContext()
        {
            GremlinToSqlContext inputContext = GetInputContext();

            return GremlinUtil.ProcessByFunctionStep("min", inputContext);
        }
    }
}