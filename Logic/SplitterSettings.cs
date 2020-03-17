﻿using System.ComponentModel;
namespace LiveSplit.OriWotW {
    public class SplitterSettings {
        public BindingList<Split> Autosplits = new BindingList<Split>();
        public bool NoPause;

        public SplitterSettings() {
            Autosplits.AllowNew = true;
            Autosplits.AllowRemove = true;
            Autosplits.AllowEdit = true;
            NoPause = false;
        }
    }
}