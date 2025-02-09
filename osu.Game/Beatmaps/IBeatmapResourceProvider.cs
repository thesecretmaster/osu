// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Audio.Track;
using osu.Framework.Graphics.Textures;
using osu.Game.IO;

namespace osu.Game.Beatmaps
{
    internal interface IBeatmapResourceProvider : IStorageResourceProvider
    {
        /// <summary>
        /// Retrieve a global large texture store, used for loading beatmap backgrounds.
        /// </summary>
        TextureStore LargeTextureStore { get; }

        /// <summary>
        /// Retrieve a global large texture store, used specifically for retrieving cropped beatmap panel backgrounds.
        /// </summary>
        TextureStore BeatmapPanelTextureStore { get; }

        /// <summary>
        /// Access a global track store for retrieving beatmap tracks from.
        /// </summary>
        ITrackStore Tracks { get; }
    }
}
