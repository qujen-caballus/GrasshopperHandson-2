using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace IntroComponent
{
    public class IntroComponentInfo : GH_AssemblyInfo
    {
        public override string Name => "IntroComponent";

        public override Bitmap Icon => null;
        public override string Description => "";

        public override Guid Id => new Guid("4bcfdc31-435c-428b-8b2f-8add1fba79dd");

        public override string AuthorName => "qujen";

        public override string AuthorContact => "";

    }
}
