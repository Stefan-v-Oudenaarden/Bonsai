using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Names.Real.Template
{
    internal class TemplateMaleGiven : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public TemplateMaleGiven()
        {
            Entries = new()
            {
                "",
            };
        }
    }
}