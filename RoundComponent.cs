using System;
using System.Drawing;
using Grasshopper.GUI;
using Grasshopper.GUI.Canvas;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;
using Grasshopper.Kernel.Attributes;

namespace GHcomponents_by_qujen
{
    public class RoundComponent : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the MyComponent4 class.
        /// </summary>
        public RoundComponent()
          : base("RoundComponent", "丸",
              "Description",
               "qujenCmp", "Primitive")
        {
        }

        public override void CreateAttributes()
        {
            m_attributes = new RoundAttributes(this);
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon => null;


        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("90D42E20-8FFB-4F5A-A2FD-F8D934807AA0");


        public class RoundAttributes : GH_ComponentAttributes
        {
            public RoundAttributes(RoundComponent owner) : base(owner) { }
            protected override void Layout()
            {
                base.Layout();
            }




            protected override void Render(GH_Canvas canvas, Graphics graphics, GH_CanvasChannel channel)
            {
                GH_Capsule capsule = GH_Capsule.CreateCapsule(Bounds, GH_Palette.Normal, 100, 0);
                capsule.AddOutputGrip(OutputGrip.Y);
                capsule.Render(graphics, Selected, Owner.Locked, true);
                capsule.Dispose();
                capsule = null;
            }
        }
    }
}