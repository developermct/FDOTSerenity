﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace FDOTSerenity.Northwind
{
    public partial class NotesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "FDOTSerenity.Northwind.NotesEditor";

        public NotesEditorAttribute()
            : base(Key)
        {
        }
    }
}

