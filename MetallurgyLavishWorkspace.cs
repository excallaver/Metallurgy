﻿
// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated from BenefitTemplate.tt/>

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;

    [Serialized]
    [LocDisplayName("Lavish Workspace: Metallurgy")]
    [LocDescription("Increases the tier requirement of tables by 0.2, but reduces the resources needed by 5 percent.(Only applies to claimed workstations)")]
    public partial class MetallurgyLavishWorkspaceTalentGroup : TalentGroup
    {
        public MetallurgyLavishWorkspaceTalentGroup()
        {
            Talents = new Type[]
            {
                typeof(MetallurgyLavishResourcesTalent),
                typeof(MetallurgyLavishReqTalent),
            };
            this.OwningSkill = typeof(MetallurgySkill);
            this.Level = 6;
        }
    }

    [Serialized]
    public partial class MetallurgyLavishResourcesTalent : LavishWorkspaceTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(MetallurgyLavishWorkspaceTalentGroup); } }
        public MetallurgyLavishResourcesTalent()
        {
            this.Value = 0.95f;
        }
    }
    [Serialized]
    public partial class MetallurgyLavishReqTalent : LavishWorkspaceTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(MetallurgyLavishWorkspaceTalentGroup); } }
        public MetallurgyLavishReqTalent()
        {
            this.Value = 0.2f;
        }
    }
}