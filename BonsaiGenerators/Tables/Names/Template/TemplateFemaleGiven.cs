using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Names.Real.Template
{
    internal class TemplateFemaleGiven : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public TemplateFemaleGiven()
        {
            Entries = new()
            {
                "",
            };
        }
    }
}