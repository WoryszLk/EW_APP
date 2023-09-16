using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;

namespace EzawodyWorsonEnterpraicment.Animations
{
    public class GridLengthAnimation : AnimationTimeline
    {
        public override Type TargetPropertyType => typeof(GridLength);

        protected override Freezable CreateInstanceCore()
        {
            return new GridLengthAnimation();
        }

        public override object GetCurrentValue(
            object defaultOriginValue,
            object defaultDestinationValue,
            AnimationClock animationClock)
        {
            double fromVal = ((GridLength)defaultOriginValue).Value;
            double toVal = ((GridLength)defaultDestinationValue).Value;
            double animatedValue = ((toVal - fromVal) * animationClock.CurrentProgress.Value) + fromVal;
            return new GridLength(animatedValue);
        }
    }
}
