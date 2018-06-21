using System;
namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        public string Name { get; set; }

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override string ToString() => $"Drawing {Name} as {renderer.WhatToRenderAs}";
    }
}
