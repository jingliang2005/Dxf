// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Entities
{

    /// <summary>
    /// DxfEntitySection class
    /// </summary>
    public partial class DxfEntitySection : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Section; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R2007; } }

        public int State { get; set; }
        public int Flags { get; set; }
        public string Name { get; set; }
        public DxfVector VerticalDirection { get; set; }
        public double TopHeight { get; set; }
        public double BottomHeight { get; set; }
        public short IndicatorTransparency { get; set; }
        public DxfColor IndicatorColor { get; set; }
        public string IndicatorColorName { get; set; }
        private int VertexCount { get; set; }
        private List<double> VertexX { get; set; }
        private List<double> VertexY { get; set; }
        private List<double> VertexZ { get; set; }
        private int BackLineVertexCount { get; set; }
        private List<double> BackLineVertexX { get; set; }
        private List<double> BackLineVertexY { get; set; }
        private List<double> BackLineVertexZ { get; set; }
        public uint GeometrySettingsHandle { get; set; }

        public DxfEntitySection()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.State = 0;
            this.Flags = 0;
            this.Name = null;
            this.VerticalDirection = DxfVector.ZAxis;
            this.TopHeight = 0.0;
            this.BottomHeight = 0.0;
            this.IndicatorTransparency = 0;
            this.IndicatorColor = DxfColor.ByLayer;
            this.IndicatorColorName = null;
            this.VertexCount = 0;
            this.VertexX = new List<double>();
            this.VertexY = new List<double>();
            this.VertexZ = new List<double>();
            this.BackLineVertexCount = 0;
            this.BackLineVertexX = new List<double>();
            this.BackLineVertexY = new List<double>();
            this.BackLineVertexZ = new List<double>();
            this.GeometrySettingsHandle = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbSection"));
            pairs.Add(new DxfCodePair(90, (this.State)));
            pairs.Add(new DxfCodePair(91, (this.Flags)));
            pairs.Add(new DxfCodePair(1, (this.Name)));
            pairs.Add(new DxfCodePair(10, VerticalDirection?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, VerticalDirection?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, VerticalDirection?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.TopHeight)));
            pairs.Add(new DxfCodePair(41, (this.BottomHeight)));
            pairs.Add(new DxfCodePair(70, (this.IndicatorTransparency)));
            pairs.Add(new DxfCodePair(63, DxfColor.GetRawValue(this.IndicatorColor)));
            pairs.Add(new DxfCodePair(411, (this.IndicatorColorName)));
            pairs.Add(new DxfCodePair(92, Vertices.Count));
            foreach (var item in Vertices)
            {
                pairs.Add(new DxfCodePair(11, item.X));
                pairs.Add(new DxfCodePair(21, item.Y));
                pairs.Add(new DxfCodePair(31, item.Z));
            }

            pairs.Add(new DxfCodePair(93, BackLineVertices.Count));
            foreach (var item in BackLineVertices)
            {
                pairs.Add(new DxfCodePair(12, item.X));
                pairs.Add(new DxfCodePair(22, item.Y));
                pairs.Add(new DxfCodePair(32, item.Z));
            }

            pairs.Add(new DxfCodePair(360, UIntHandle(this.GeometrySettingsHandle)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.Name = (pair.StringValue);
                    break;
                case 10:
                    this.VerticalDirection.X = pair.DoubleValue;
                    break;
                case 20:
                    this.VerticalDirection.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.VerticalDirection.Z = pair.DoubleValue;
                    break;
                case 11:
                    this.VertexX.Add((pair.DoubleValue));
                    break;
                case 12:
                    this.BackLineVertexX.Add((pair.DoubleValue));
                    break;
                case 21:
                    this.VertexY.Add((pair.DoubleValue));
                    break;
                case 22:
                    this.BackLineVertexY.Add((pair.DoubleValue));
                    break;
                case 31:
                    this.VertexZ.Add((pair.DoubleValue));
                    break;
                case 32:
                    this.BackLineVertexZ.Add((pair.DoubleValue));
                    break;
                case 40:
                    this.TopHeight = (pair.DoubleValue);
                    break;
                case 41:
                    this.BottomHeight = (pair.DoubleValue);
                    break;
                case 63:
                    this.IndicatorColor = DxfColor.FromRawValue(pair.ShortValue);
                    break;
                case 70:
                    this.IndicatorTransparency = (pair.ShortValue);
                    break;
                case 90:
                    this.State = (pair.IntegerValue);
                    break;
                case 91:
                    this.Flags = (pair.IntegerValue);
                    break;
                case 92:
                    this.VertexCount = (pair.IntegerValue);
                    break;
                case 93:
                    this.BackLineVertexCount = (pair.IntegerValue);
                    break;
                case 360:
                    this.GeometrySettingsHandle = UIntHandle(pair.StringValue);
                    break;
                case 411:
                    this.IndicatorColorName = (pair.StringValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
