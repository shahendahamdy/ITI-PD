using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    
    internal class Duration
    {
        int hours;
        int minutes;
        int seconds;
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration(int scnds)
        {
            hours= scnds/(60*60); //1=3600/60*60
            minutes= (scnds-(hours*60*60))/60;//3600-3600=0
            seconds= scnds-(hours*60*60)-(minutes*60);///3600-0-
        }
        //3600 -->3600/60*60
       

        public override string ToString()
        {
            string x= "";
            if (hours != 0) x += "Hours " + hours+" ";
            if (minutes != 0) x += "Minutes " + minutes + " ";
            if (seconds != 0) x += "seconds  " + seconds + " ";
            return x;
        }

        public override bool Equals(object? obj)
        {
            if(obj is Duration)
            {
                Duration other = (Duration)obj;
                return other.hours == this.hours && other.minutes == minutes && other.seconds == seconds; 
            }
            return false;
        }
        ///
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration
            (
                 a.hours + b.hours,
                 a.minutes + b.minutes,
                a.seconds + b.seconds

            );
        }
        public static int toSeconds(int h, int m, int s)
        {
            return (h * 60 * 60) + (m * 60) + (s);
        }
        //D+NUM
        public static Duration operator +(Duration a, int b)
        {
            int hour = b / (60 * 60); //
            int minute = (b - (hour * 60 * 60)) / 60;//3600-3600=0
            int second = b - (hour * 60 * 60) - (minute * 60);///3600-0-

            return new Duration
            (
                 a.hours + hour,
                 a.minutes + minute,
                a.seconds + second

            );
        }
        //NUM+D

        public static Duration operator +( int b, Duration a)
        {
            int hour = b / (60 * 60); //
            int minute = (b - (hour * 60 * 60)) / 60;//3600-3600=0
            int second = b - (hour * 60 * 60) - (minute * 60);///3600-0-

            return new Duration
            (
                 a.hours + hour,
                 a.minutes + minute,
                a.seconds + second

            );
        }
        //D++
        public static Duration operator ++(Duration a)
        {
            int b = Duration.toSeconds(a.hours, a.minutes, a.seconds) + 60;

            int hour = b / (60 * 60); //
            int minute = (b - (hour * 60 * 60)) / 60;//3600-3600=0
            int second = b - (hour * 60 * 60) - (minute * 60);///3600-0-

            return new Duration
            (
                  hour,
                  minute,
                 second
             );

        }
        //D--
        public static Duration operator --(Duration a)
        {
            int b = Duration.toSeconds(a.hours, a.minutes, a.seconds) - 60;

            int hour = b / (60 * 60); //
            int minute = (b - (hour * 60 * 60)) / 60;//3600-3600=0
            int second = b - (hour * 60 * 60) - (minute * 60);///3600-0-

            return new Duration
            (
                  hour,
                  minute,
                 second
             );

        }
        public static bool operator >(Duration a, Duration b)
        {

            return Duration.toSeconds(a.hours, a.minutes, a.seconds) > Duration.toSeconds(b.hours, b.minutes, b.seconds);
        }
        public static bool operator <(Duration a, Duration b)
        {

            return Duration.toSeconds(a.hours, a.minutes, a.seconds) < Duration.toSeconds(b.hours, b.minutes, b.seconds);
        }
        public static bool operator >=(Duration a, Duration b)
        {

            return Duration.toSeconds(a.hours, a.minutes, a.seconds) >= Duration.toSeconds(b.hours, b.minutes, b.seconds);
        }
        public static bool operator <=(Duration a, Duration b)
        {

            return Duration.toSeconds(a.hours, a.minutes, a.seconds) <= Duration.toSeconds(b.hours, b.minutes, b.seconds);
        }
        public static implicit operator bool(Duration a)
        {

            return Duration.toSeconds(a.hours, a.minutes, a.seconds) != 0;
        }
        public static explicit operator DateTime(Duration a)
        {

            return new System.DateTime(2023, 6, 28, a.hours, a.minutes, a.seconds);
        }


        /// If(D1>D2);
        /// If(D1<=D2);
        ///If(D1);
        ///DateTime Obj = (DateTime)D1
        //System.DateTime newDate1 = DateTime.Now.Add(duration);  
        //System.Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM  


    }
}
