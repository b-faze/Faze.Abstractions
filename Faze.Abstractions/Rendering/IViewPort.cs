﻿using System.Net;

namespace Faze.Abstractions.Rendering
{
    public interface IViewport
    {
        float Left { get; }
        float Top { get; }
        float Scale { get; }

        Viewport Zoom(float x, float y, float newScale);
        Viewport Pan(float dx, float dy);
    }
}
