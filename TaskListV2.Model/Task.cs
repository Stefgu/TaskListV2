﻿using System;

namespace TaskListV2.Model
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public bool TaskComplete { get; set; }

        public Priority TaskPriority { get; set; }        

        public enum Priority
        {
            low,
            medium,
            high
        }

    }
}
