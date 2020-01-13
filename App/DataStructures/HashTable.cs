// using System;
// using System.Collections.Generic;

// namespace App.DataStructures
// {
//     public interface IHashTable<TKey, TValue>
//     {
//         void Set(TKey key, TValue value);
//         TValue Get(TKey key);
//     }

//     public class HashTable<TKey, TValue> : IHashTable<TKey, TValue>
//     {
//         private TValue[] _values;

//         public HashTable()
//         {
//             _values = new TValue[1000];
//         }

//         public void Set(TKey key, TValue value)
//         {
//             var index = this.Hash(key);

//             if (index > _values.Length - 1)
//             {
//                 var uhOh = 1;
//             }

//             var currentValue = _values[index];
//             if (currentValue != default)
//             {
//                 throw new Exception("collission");
//             }

//             _values[index] = value;
//         }

//         public TValue Get(TKey key)
//         {
//             var value = _values[Hash(key)];
//             if (value == default)
//             {
//                 throw new KeyNotFoundException(key?.ToString());
//             }
//             return value;
//         }

//         protected int Hash(TKey key)
//         {
//             var hashCode = key.GetHashCode();
//             return hashCode % _values.Length;
//         }
//     }
// }
