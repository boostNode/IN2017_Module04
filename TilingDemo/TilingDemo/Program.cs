/*
*  Author: Troy Davis
*  Project: TilingDemo - Console (Chapter 9, Programming Exercise #4, pg418)
*  Class: IN 2017 (Advanced C#)
*  Date: Feb 13, 2017 
*  Revision: Original
*/

using System;

namespace TilingDemo
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("Chapter 9, Programming Exercise #4 - Tiling Demo\n");

            // instantiate and display Room objects
            Room[] rooms = {
                new Room(1, 12.0, 13.0),
                new Room(2, 15.0, 22.0),
                new Room(3, 8.0, 10.0),
                new Room(4, 12.0, 16.0),
                new Room(5, 10.0, 10.0),
                new Room(6, 9.0, 11.0),
                new Room(7, 16.0, 24.0),
                new Room(8, 30.0, 40.0),
                new Room(9, 22.0, 25.0),
                new Room(10, 32.0, 48.0)
            };

            for( int i = 0 ; i < rooms.Length ; i++ )
            {
                rooms[i].DisplayRoomInfo();
            }

            // wait on user to close console
            Console.Write("Press 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class Room
    {
        private int number;
        private double length;
        private double width;
        private double floor_area = 0.0;
        private int tile_boxes_required = 0;

        // constructor
        public Room(int n, double l, double w)
        {
            this.number = n;
            this.length = l;
            this.width = w;
            ComputeFloorArea();
            ComputeTileBoxesRequired();
        }

        // internal methods
        private void ComputeFloorArea()
        {
            this.floor_area = this.length * this.width;
        }
        private void ComputeTileBoxesRequired()
        {
            int full_coverage_boxes = 0;
            int partial_coverage_boxes = 0;
            int waste_boxes = 1;

            if( this.floor_area > 0.0 )
            {
                if( this.floor_area > 12.0 )
                {
                    full_coverage_boxes = (int)(this.floor_area / 12.0);
                }
                if( ( this.floor_area % 12.0 ) != 0 )
                {
                    partial_coverage_boxes = 1;
                }
                this.tile_boxes_required = full_coverage_boxes + partial_coverage_boxes + waste_boxes;
            }
            else
            {
                this.tile_boxes_required = 0;
            }
        }
        // external methods
        public int Number()
        {
            return this.number;
        }
        public double Length()
        {
            return this.length;
        }
        public double Width()
        {
            return this.width;
        }
        public double FloorArea()
        {
            return this.floor_area;
        }
        public int TileBoxesRequired()
        {
            return this.tile_boxes_required;
        }
        public void DisplayRoomInfo()
        {
            Console.WriteLine("\tRoom Number {0}\n\t  Length: {1}\n\t  Width: {2}\n\t  Floor Area: {3}\n\t  Tile Boxes Required: {4}\n", this.number.ToString(), this.length.ToString("F2"), this.width.ToString("F2"), this.floor_area.ToString("F2"), this.tile_boxes_required.ToString());
        }
    }
}
