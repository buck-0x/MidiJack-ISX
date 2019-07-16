using MidiJack;
using UnityEditor;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
    public struct LaunchControlXLDeviceState : IInputStateTypeInfo
    {
        public static FourCC kFormat => new FourCC('M', 'I', 'D', 'I');
        public FourCC GetFormat()
        {
            return kFormat;
        }

        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA1;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA2;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA3;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA4;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA5;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA6;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA7;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendA8;

        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB1;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB2;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB3;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB4;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB5;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB6;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB7;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float SendB8;

        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice1;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice2;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice3;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice4;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice5;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice6;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice7;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float PanDevice8;


        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider1;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider2;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider3;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider4;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider5;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider6;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider7;
        [InputControl(layout = "Axis", usage = "Twist", defaultState = "0.5")]
        public float Slider8;
    }
}

namespace UnityEngine.InputSystem
{
    [InitializeOnLoad]
    [InputControlLayout(stateType = typeof(LaunchControlXLDeviceState), isGenericTypeOfDevice = true, displayName = "Novation Launch Control XL")]
    public class LaunchControlXLDevice : InputDevice
    {
        public static LaunchControlXLDevice Current { get; private set; }

        static LaunchControlXLDevice()
        {
            InputSystem.RegisterLayout<LaunchControlXLDevice>();

            InputSystem.onBeforeUpdate += CreateDevice;
        }

        private static void CreateDevice(InputUpdateType obj)
        {
            InputSystem.onBeforeUpdate -= CreateDevice;
            if (Current == null)
            {
                InputSystem.AddDevice<LaunchControlXLDevice>().MakeCurrent();
            }
        }

        [RuntimeInitializeOnLoadMethod]
        private static void Register() { }

        public AxisControl SendA1Axis { get; private set; }
        public AxisControl SendA2Axis { get; private set; }
        public AxisControl SendA3Axis { get; private set; }
        public AxisControl SendA4Axis { get; private set; }
        public AxisControl SendA5Axis { get; private set; }
        public AxisControl SendA6Axis { get; private set; }
        public AxisControl SendA7Axis { get; private set; }
        public AxisControl SendA8Axis { get; private set; }

        public AxisControl SendB1Axis { get; private set; }
        public AxisControl SendB2Axis { get; private set; }
        public AxisControl SendB3Axis { get; private set; }
        public AxisControl SendB4Axis { get; private set; }
        public AxisControl SendB5Axis { get; private set; }
        public AxisControl SendB6Axis { get; private set; }
        public AxisControl SendB7Axis { get; private set; }
        public AxisControl SendB8Axis { get; private set; }

        public AxisControl PanDevice1Axis { get; private set; }
        public AxisControl PanDevice2Axis { get; private set; }
        public AxisControl PanDevice3Axis { get; private set; }
        public AxisControl PanDevice4Axis { get; private set; }
        public AxisControl PanDevice5Axis { get; private set; }
        public AxisControl PanDevice6Axis { get; private set; }
        public AxisControl PanDevice7Axis { get; private set; }
        public AxisControl PanDevice8Axis { get; private set; }

        public AxisControl Slider1Axis { get; private set; }
        public AxisControl Slider2Axis { get; private set; }
        public AxisControl Slider3Axis { get; private set; }
        public AxisControl Slider4Axis { get; private set; }
        public AxisControl Slider5Axis { get; private set; }
        public AxisControl Slider6Axis { get; private set; }
        public AxisControl Slider7Axis { get; private set; }
        public AxisControl Slider8Axis { get; private set; }

        private LaunchControlXLDeviceState mState;

        protected override void FinishSetup(InputDeviceBuilder builder)
        {
            SendA1Axis = builder.GetControl<AxisControl>("SendA1");
            SendA2Axis = builder.GetControl<AxisControl>("SendA2");
            SendA3Axis = builder.GetControl<AxisControl>("SendA3");
            SendA4Axis = builder.GetControl<AxisControl>("SendA4");
            SendA5Axis = builder.GetControl<AxisControl>("SendA5");
            SendA6Axis = builder.GetControl<AxisControl>("SendA6");
            SendA7Axis = builder.GetControl<AxisControl>("SendA7");
            SendA8Axis = builder.GetControl<AxisControl>("SendA8");

            SendB1Axis = builder.GetControl<AxisControl>("SendB1");
            SendB2Axis = builder.GetControl<AxisControl>("SendB2");
            SendB3Axis = builder.GetControl<AxisControl>("SendB3");
            SendB4Axis = builder.GetControl<AxisControl>("SendB4");
            SendB5Axis = builder.GetControl<AxisControl>("SendB5");
            SendB6Axis = builder.GetControl<AxisControl>("SendB6");
            SendB7Axis = builder.GetControl<AxisControl>("SendB7");
            SendB8Axis = builder.GetControl<AxisControl>("SendB8");

            PanDevice1Axis = builder.GetControl<AxisControl>("PanDevice1");
            PanDevice2Axis = builder.GetControl<AxisControl>("PanDevice2");
            PanDevice3Axis = builder.GetControl<AxisControl>("PanDevice3");
            PanDevice4Axis = builder.GetControl<AxisControl>("PanDevice4");
            PanDevice5Axis = builder.GetControl<AxisControl>("PanDevice5");
            PanDevice6Axis = builder.GetControl<AxisControl>("PanDevice6");
            PanDevice7Axis = builder.GetControl<AxisControl>("PanDevice7");
            PanDevice8Axis = builder.GetControl<AxisControl>("PanDevice8");

            Slider1Axis = builder.GetControl<AxisControl>("Slider1");
            Slider2Axis = builder.GetControl<AxisControl>("Slider2");
            Slider3Axis = builder.GetControl<AxisControl>("Slider3");
            Slider4Axis = builder.GetControl<AxisControl>("Slider4");
            Slider5Axis = builder.GetControl<AxisControl>("Slider5");
            Slider6Axis = builder.GetControl<AxisControl>("Slider6");
            Slider7Axis = builder.GetControl<AxisControl>("Slider7");
            Slider8Axis = builder.GetControl<AxisControl>("Slider8");

            InputSystem.onAfterUpdate += FireDefaultState;

        }

        private void FireDefaultState(InputUpdateType obj)
        {
            InputSystem.onAfterUpdate -= FireDefaultState;

            mState.Slider1 = 0.5f;
            mState.Slider2 = 0.5f;
            mState.Slider3 = 0.5f;
            mState.Slider4 = 0.5f;
            mState.Slider5 = 0.5f;
            mState.Slider6 = 0.5f;
            mState.Slider7 = 0.5f;
            mState.Slider8 = 0.5f;

            mState.PanDevice1 = 0.5f;
            mState.PanDevice2 = 0.5f;
            mState.PanDevice3 = 0.5f;
            mState.PanDevice4 = 0.5f;
            mState.PanDevice5 = 0.5f;
            mState.PanDevice6 = 0.5f;
            mState.PanDevice7 = 0.5f;
            mState.PanDevice8 = 0.5f;

            mState.SendA1 = 0.5f;
            mState.SendA2 = 0.5f;
            mState.SendA3 = 0.5f;
            mState.SendA4 = 0.5f;
            mState.SendA5 = 0.5f;
            mState.SendA6 = 0.5f;
            mState.SendA7 = 0.5f;
            mState.SendA8 = 0.5f;

            mState.SendB1 = 0.5f;
            mState.SendB2 = 0.5f;
            mState.SendB3 = 0.5f;
            mState.SendB4 = 0.5f;
            mState.SendB5 = 0.5f;
            mState.SendB6 = 0.5f;
            mState.SendB7 = 0.5f;
            mState.SendB8 = 0.5f;

            InputSystem.QueueStateEvent(this, mState);
        }

        protected override void OnAdded()
        {
            MidiMaster.knobDelegate += KnobDelegate;
            base.OnAdded();
        }

        protected override void OnRemoved()
        {
            MidiMaster.knobDelegate -= KnobDelegate;
        }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            Current = this;
        }

        private void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue)
        {

            bool publishEvent = true;

            switch (knobnumber)
            {
                case 0x0D:
                    mState.SendA1 = knobvalue;
                    break;
                case 0x0E:
                    mState.SendA2 = knobvalue;
                    break;
                case 0x0F:
                    mState.SendA3 = knobvalue;
                    break;
                case 0x10:
                    mState.SendA4 = knobvalue;
                    break;
                case 0x11:
                    mState.SendA5 = knobvalue;
                    break;
                case 0x12:
                    mState.SendA6 = knobvalue;
                    break;
                case 0x13:
                    mState.SendA7 = knobvalue;
                    break;
                case 0x14:
                    mState.SendA8 = knobvalue;
                    break;

                case 0x1D:
                    mState.SendB1 = knobvalue;
                    break;
                case 0x1E:
                    mState.SendB2 = knobvalue;
                    break;
                case 0x1F:
                    mState.SendB3 = knobvalue;
                    break;
                case 0x20:
                    mState.SendB4 = knobvalue;
                    break;
                case 0x21:
                    mState.SendB5 = knobvalue;
                    break;
                case 0x22:
                    mState.SendB6 = knobvalue;
                    break;
                case 0x23:
                    mState.SendB7 = knobvalue;
                    break;
                case 0x24:
                    mState.SendB8 = knobvalue;
                    break;

                case 0x31:
                    mState.PanDevice1 = knobvalue;
                    break;
                case 0x32:
                    mState.PanDevice2 = knobvalue;
                    break;
                case 0x33:
                    mState.PanDevice3 = knobvalue;
                    break;
                case 0x34:
                    mState.PanDevice4 = knobvalue;
                    break;
                case 0x35:
                    mState.PanDevice5 = knobvalue;
                    break;
                case 0x36:
                    mState.PanDevice6 = knobvalue;
                    break;
                case 0x37:
                    mState.PanDevice7 = knobvalue;
                    break;
                case 0x38:
                    mState.PanDevice8 = knobvalue;
                    break;

                case 0x4D:
                    mState.Slider1 = knobvalue;
                    break;
                case 0x4E:
                    mState.Slider2 = knobvalue;
                    break;
                case 0x4F:
                    mState.Slider3 = knobvalue;
                    break;
                case 0x50:
                    mState.Slider4 = knobvalue;
                    break;
                case 0x51:
                    mState.Slider5 = knobvalue;
                    break;
                case 0x52:
                    mState.Slider6 = knobvalue;
                    break;
                case 0x53:
                    mState.Slider7 = knobvalue;
                    break;
                case 0x54:
                    mState.Slider8 = knobvalue;
                    break;

                default:
                    publishEvent = false;
                    break;
            }

            if (publishEvent)
            {
                InputSystem.QueueStateEvent(this, mState);
            }
        }
    }
}