//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace AutomaticGenerators
{
    #pragma warning disable // Disable all warnings

    public partial class AnimationSettings
    {
		private double duration = 2D;
		public double Duration
		{
			get { return duration; }
			set { duration = value; }
		}

		private double initialRadius = 0.5D;
		public double InitialRadius
		{
			get { return initialRadius; }
			set { initialRadius = value; }
		}

		private double initialVirtualDistance = 12.5D;
		public double InitialVirtualDistance
		{
			get { return initialVirtualDistance; }
			set { initialVirtualDistance = value; }
		}

		private double linearApproachingVelocity = 25D;
		public double LinearApproachingVelocity
		{
			get { return linearApproachingVelocity; }
			set { linearApproachingVelocity = value; }
		}

		private double maxRadius = 25D;
		public double MaxRadius
		{
			get { return maxRadius; }
			set { maxRadius = value; }
		}

		private double monitorDistance = 25D;
		public double MonitorDistance
		{
			get { return monitorDistance; }
			set { monitorDistance = value; }
		}



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class Color
    {
		private double a = 1D;
		public double A
		{
			get { return a; }
			set { a = value; }
		}

		private double b = 0D;
		public double B
		{
			get { return b; }
			set { b = value; }
		}

		private double g = 0D;
		public double G
		{
			get { return g; }
			set { g = value; }
		}

		private double r = 0D;
		public double R
		{
			get { return r; }
			set { r = value; }
		}



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class ControlNoisyStimuli
    {
        public AnimationSettings AnimationSettings { get; set; }

        public Color BackgroundColor { get; set; }

        public double DelayOffset { get; set; }

        public double DelayOnset { get; set; }

		private double diameter = 0.1D;
		public double Diameter
		{
			get { return diameter; }
			set { diameter = value; }
		}

        public Color OffColor { get; set; }

        public Color OnColor { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class LoomingCircleStimuli
    {
        public AnimationSettings AnimationSettings { get; set; }

        public Color BackgroundColor { get; set; }

        public Color Color { get; set; }

        public double DelayOffset { get; set; }

        public double DelayOnset { get; set; }

		private double diameter = 0.1D;
		public double Diameter
		{
			get { return diameter; }
			set { diameter = value; }
		}



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class LoomingImageStimuli
    {
        public AnimationSettings AnimationSettings { get; set; }

        public Color BackgroundColor { get; set; }

        public double DelayOffset { get; set; }

        public double DelayOnset { get; set; }

		private double scaleX = 1D;
		public double ScaleX
		{
			get { return scaleX; }
			set { scaleX = value; }
		}

		private double scaleY = 1D;
		public double ScaleY
		{
			get { return scaleY; }
			set { scaleY = value; }
		}

		private string textureName = "";
		public string TextureName
		{
			get { return textureName; }
			set { textureName = value; }
		}



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class OptogeneticsStimuli
    {
		private double amplitude = 1D;
		public double Amplitude
		{
			get { return amplitude; }
			set { amplitude = value; }
		}

		private double duration = 1D;
		public double Duration
		{
			get { return duration; }
			set { duration = value; }
		}

		private int dutyCycle = 50;
		public int DutyCycle
		{
			get { return dutyCycle; }
			set { dutyCycle = value; }
		}

		private double frequency = 10D;
		public double Frequency
		{
			get { return frequency; }
			set { frequency = value; }
		}

		private OptogeneticsStimuliLedTarget ledTarget = AutomaticGenerators.OptogeneticsStimuliLedTarget.None;
		public OptogeneticsStimuliLedTarget LedTarget
		{
			get { return ledTarget; }
			set { ledTarget = value; }
		}

		private OptogeneticsStimuliMode mode = AutomaticGenerators.OptogeneticsStimuliMode.Continuous;
		public OptogeneticsStimuliMode Mode
		{
			get { return mode; }
			set { mode = value; }
		}



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class TrialSettings
    {
        public ControlNoisyStimuli ControlNoisyStimuli { get; set; }

        public LoomingCircleStimuli LoomingCircleStimuli { get; set; }

        public LoomingImageStimuli LoomingImageStimuli { get; set; }

        public OptogeneticsStimuli OptogeneticsStimuli { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public partial class BonFlyStimuli
    {
        public System.Collections.Generic.IList<TrialSettings> Trials { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    public enum OptogeneticsStimuliLedTarget
    {

        None = 0,


        Led0 = 1,


        Led1 = 2,


        Both = 3,


    }

    public enum OptogeneticsStimuliMode
    {

        Continuous = 0,


        Pulsed = 1,


    }
}
