namespace System
{
    internal class SR
    {
        public static readonly string DebugAssertBanner = "---- DEBUG ASSERTION FAILED ----";
        public static readonly string DebugAssertShortMessage = "---- Assert Short Message ----";
        public static readonly string DebugAssertLongMessage = "---- Assert Long Message ----";
        public static readonly string CollectionModifiedDuringEnumeration = "Collection was modified; enumeration operation may not execute.";
        public static readonly string Arg_HTCapacityOverflow = "Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.";
        public static readonly string Arg_WrongType = "The value '{0}' is not of type '{1}' and cannot be used in this generic collection.";
        public static readonly string Argument_AddingDuplicate = "Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'";
        public static readonly string Arg_ArrayPlusOffTooSmall = "";
        public static readonly string InvalidOperation_EnumOpCantHappen = "";
        public static readonly string Argument_InvalidArrayType = "";
        public static readonly string NotSupported_KeyCollectionSet = "";
        public static readonly string Arg_RankMultiDimNotSupported = "";
        public static readonly string Arg_NonZeroLowerBound = "";
        public static readonly string ArgumentOutOfRange_NeedNonNegNum = "";
        public static readonly string NotSupported_ValueCollectionSet = "";
        public static readonly string InvalidOperation_EnumFailedVersion = "";
        public static readonly string ArgumentOutOfRange_NeedNonNegNumRequired = "";
        public static readonly string Argument_InvalidOffLen = "";
        public static readonly string InvalidOperation_EmptyStack = "";
        public static readonly string InvalidOperation_EnumNotStarted = "";
        public static readonly string InvalidOperation_EnumEnded = "";
        public static readonly string CapacityMustBeGreaterThanOrEqualToCount = "";
        public static readonly string CapacityMustEqualCountOnMove = "";
        public static readonly string CannotFindOldValue = "";
        public static readonly string ArrayLengthsNotEqual = "";
        public static readonly string DuplicateKey = "";
        public static readonly string ArrayInitializedStateNotEqual = "";
        public static readonly string InvalidOperationOnDefaultArray = "";
        public static readonly string InvalidEmptyOperation = "";

        public static string Format(string fmt, string arg1)
        {
            return string.Format(fmt, arg1);
        }

        public static string Format(string fmt, object arg1, object arg2)
        {
            return string.Format(fmt, arg1, arg2);
        }
    }
}