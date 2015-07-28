﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter6 {

    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public virtual void DoWork(int hours, WorkType workType) {
            for(int i = 0; i < hours; i++) {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i+1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType) {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del != null) {
                del(this, new WorkPerformedEventArgs(hours,workType));
            }
        }
        protected virtual void OnWorkCompleted() {
            var del = WorkCompleted as EventHandler;
            if(del != null) {
                del(this, EventArgs.Empty);
            }
        }
    }

    public class WorkPerformedEventArgs : EventArgs {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
        public WorkPerformedEventArgs(int hours, WorkType worktype) {
            Hours = hours;
            WorkType = worktype;
        }
    }
}
