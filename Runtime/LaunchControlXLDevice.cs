using MidiJack;
using MidiJackISX;
using UnityEditor;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace MidiJackISX
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
        public static LaunchControlXLDevice current { get; private set; }

        static LaunchControlXLDevice()
        {
            InputSystem.RegisterLayout<LaunchControlXLDevice>();

            InputSystem.onBeforeUpdate += CreateDevice;
        }

        static void CreateDevice(InputUpdateType obj)
        {
            InputSystem.onBeforeUpdate -= CreateDevice;
            if (current == null)
            {
                InputSystem.AddDevice<LaunchControlXLDevice>().MakeCurrent();
            }
        }

        [RuntimeInitializeOnLoadMethod]
        static void Register() { }

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

        LaunchControlXLDeviceState m_State;

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

        void FireDefaultState(InputUpdateType obj)
        {
            InputSystem.onAfterUpdate -= FireDefaultState;

            m_State.Slider1 = 0.5f;
            m_State.Slider2 = 0.5f;
            m_State.Slider3 = 0.5f;
            m_State.Slider4 = 0.5f;
            m_State.Slider5 = 0.5f;
            m_State.Slider6 = 0.5f;
            m_State.Slider7 = 0.5f;
            m_State.Slider8 = 0.5f;

            m_State.PanDevice1 = 0.5f;
            m_State.PanDevice2 = 0.5f;
            m_State.PanDevice3 = 0.5f;
            m_State.PanDevice4 = 0.5f;
            m_State.PanDevice5 = 0.5f;
            m_State.PanDevice6 = 0.5f;
            m_State.PanDevice7 = 0.5f;
            m_State.PanDevice8 = 0.5f;

            m_State.SendA1 = 0.5f;
            m_State.SendA2 = 0.5f;
            m_State.SendA3 = 0.5f;
            m_State.SendA4 = 0.5f;
            m_State.SendA5 = 0.5f;
            m_State.SendA6 = 0.5f;
            m_State.SendA7 = 0.5f;
            m_State.SendA8 = 0.5f;

            m_State.SendB1 = 0.5f;
            m_State.SendB2 = 0.5f;
            m_State.SendB3 = 0.5f;
            m_State.SendB4 = 0.5f;
            m_State.SendB5 = 0.5f;
            m_State.SendB6 = 0.5f;
            m_State.SendB7 = 0.5f;
            m_State.SendB8 = 0.5f;

            InputSystem.QueueStateEvent(this, m_State);
        }

        protected override void OnAdded()
        {
            MidiMaster.knobDelegate += KnobDelegate;
        }

        protected override void OnRemoved()
        {
            MidiMaster.knobDelegate -= KnobDelegate;
        }

        public override void MakeCurrent()
        {
            current = this;
        }

        void KnobDelegate(MidiChannel channel, int knobnumber, float knobvalue)
        {
            var publishEvent = true;

            switch (knobnumber)
            {
                case 0x0D:
                    m_State.SendA1 = knobvalue;
                    break;
                case 0x0E:
                    m_State.SendA2 = knobvalue;
                    break;
                case 0x0F:
                    m_State.SendA3 = knobvalue;
                    break;
                case 0x10:
                    m_State.SendA4 = knobvalue;
                    break;
                case 0x11:
                    m_State.SendA5 = knobvalue;
                    break;
                case 0x12:
                    m_State.SendA6 = knobvalue;
                    break;
                case 0x13:
                    m_State.SendA7 = knobvalue;
                    break;
                case 0x14:
                    m_State.SendA8 = knobvalue;
                    break;

                case 0x1D:
                    m_State.SendB1 = knobvalue;
                    break;
                case 0x1E:
                    m_State.SendB2 = knobvalue;
                    break;
                case 0x1F:
                    m_State.SendB3 = knobvalue;
                    break;
                case 0x20:
                    m_State.SendB4 = knobvalue;
                    break;
                case 0x21:
                    m_State.SendB5 = knobvalue;
                    break;
                case 0x22:
                    m_State.SendB6 = knobvalue;
                    break;
                case 0x23:
                    m_State.SendB7 = knobvalue;
                    break;
                case 0x24:
                    m_State.SendB8 = knobvalue;
                    break;

                case 0x31:
                    m_State.PanDevice1 = knobvalue;
                    break;
                case 0x32:
                    m_State.PanDevice2 = knobvalue;
                    break;
                case 0x33:
                    m_State.PanDevice3 = knobvalue;
                    break;
                case 0x34:
                    m_State.PanDevice4 = knobvalue;
                    break;
                case 0x35:
                    m_State.PanDevice5 = knobvalue;
                    break;
                case 0x36:
                    m_State.PanDevice6 = knobvalue;
                    break;
                case 0x37:
                    m_State.PanDevice7 = knobvalue;
                    break;
                case 0x38:
                    m_State.PanDevice8 = knobvalue;
                    break;

                case 0x4D:
                    m_State.Slider1 = knobvalue;
                    break;
                case 0x4E:
                    m_State.Slider2 = knobvalue;
                    break;
                case 0x4F:
                    m_State.Slider3 = knobvalue;
                    break;
                case 0x50:
                    m_State.Slider4 = knobvalue;
                    break;
                case 0x51:
                    m_State.Slider5 = knobvalue;
                    break;
                case 0x52:
                    m_State.Slider6 = knobvalue;
                    break;
                case 0x53:
                    m_State.Slider7 = knobvalue;
                    break;
                case 0x54:
                    m_State.Slider8 = knobvalue;
                    break;

                default:
                    publishEvent = false;
                    break;
            }

            if (publishEvent)
            {
                InputSystem.QueueStateEvent(this, m_State);
            }
        }
    }
}