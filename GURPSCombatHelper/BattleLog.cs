using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GURPSCombatHelper
{
    public class BattleLog
    {
        /// <summary>
        /// Maximum number of lines allowed in the logs
        /// </summary>
        private const int MAX_LOG_LENGTH = 100;

        /// <summary>
        /// Log strings that have been displayed to the window already
        /// </summary>
        private List<string> mStaleLog;

        /// <summary>
        /// Log strings that have not been displayed yet
        /// </summary>
        private List<string> mFreshLog;

        /// <summary>
        /// Creates a new Battle Log
        /// </summary>
        public BattleLog()
        {
            mStaleLog = new List<string>();
            mFreshLog = new List<string>();
        }

        /// <summary>
        /// Indicate that the Fresh log files have been handled
        /// </summary>
        private void makeStale()
        {
            mStaleLog.AddRange(mFreshLog);
            mFreshLog.Clear();
        }

        /// <summary>
        /// Indicates if there are any fresh logs available
        /// </summary>
        /// <returns>True, if there is a fresh log, False, otherwise</returns>
        public bool anyFresh()
        {
            if (mFreshLog.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Remove any excess log messages, oldest first.
        /// </summary>
        private void pruneStale()
        {
            if (mStaleLog.Count > MAX_LOG_LENGTH)
            {
                mStaleLog.RemoveRange(0, mStaleLog.Count - MAX_LOG_LENGTH);                
            }
        }

        /// <summary>
        /// Add a new log to the logger. It hasn't been displayed, so it's Fresh.
        /// Also automatically appends a newline character
        /// </summary>
        /// <param name="newLog">The log message to add</param>
        public void addLog(string newLog)
        {
            mFreshLog.Add(newLog + "\n");
        }

        /// <summary>
        /// Returns all stored logs
        /// </summary>
        /// <param name="convertToStale">if true, all Fresh logs will be made Stale</param>
        /// <returns></returns>
        public List<string> getAllLogs(bool convertToStale = true)
        {
            List<string> output = new List<string>(mStaleLog);
            output.AddRange(mFreshLog);
            if (convertToStale)
            {
                makeStale();
            }
            return output;
        }

        /// <summary>
        /// Returns all fresh logs
        /// </summary>
        /// <param name="convertToStale">If true, all Fresh logs will be made Stale</param>
        /// <returns></returns>
        public List<string> getFreshLogs(bool convertToStale = true)
        {
            List<string> output = new List<string>(mFreshLog);
            if (convertToStale)
            {
                makeStale();
            }
            return output;
        }
        

    }
}
