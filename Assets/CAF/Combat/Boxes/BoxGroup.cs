﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CAF.Combat
{
    [System.Serializable]
    public class BoxGroup
    {
        public int ID;
        public int activeFramesStart = 1;
        public int activeFramesEnd = 1;
        public BoxGroupType hitGroupType;
        public List<BoxDefinition> boxes = new List<BoxDefinition>();
        public bool attachToEntity = true;

        public AttackDefinition throwConfirm;

        [SerializeField] public HitInfo hitboxHitInfo = new HitInfo();

        public BoxGroup()
        {

        }

        public BoxGroup(BoxGroup other)
        {
            ID = other.ID;
            activeFramesStart = other.activeFramesStart;
            activeFramesEnd = other.activeFramesEnd;
            hitGroupType = other.hitGroupType;
            boxes = new List<BoxDefinition>(other.boxes);
            attachToEntity = other.attachToEntity;
            hitboxHitInfo = new HitInfo(other.hitboxHitInfo);
        }
    }
}
