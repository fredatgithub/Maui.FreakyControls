﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;

namespace Maui.FreakyControls
{
    public partial class FreakyEntryHandler : EntryHandler
    {
        public FreakyEntryHandler()
        {
            Mapper.AppendToMapping("FreakyEntryCustomization", MapFreakyEntry);
        }

        private void MapFreakyEntry(IEntryHandler entryHandler, IEntry entry)
        {
            if (entry is FreakyEntry freakyEntry && entryHandler is FreakyEntryHandler freakyEntryHandler)
            {
                if (freakyEntry.ImageSource != default(ImageSource))
                {
                    freakyEntryHandler.HandleAndAlignImageSourceAsync(freakyEntry);
                }

                HandleAllowCopyPaste(freakyEntry);
            }
        }
    }
}
