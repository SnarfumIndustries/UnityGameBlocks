using System;
using System.IO;
using UnityEngine;

namespace SI.PlayerData
{
    /// <summary>
    ///     Manages data persistence for a specific class, using JSON as the storage format.
    /// </summary>
    /// <typeparam name="T">The type of object that this manager handles. Must be a class and have a parameterless constructor.</typeparam>
    public class JsonDataManager<T> where T : class, new()
    {
        private readonly string _filePath;
        private T _cachedData;

        /// <summary>
        ///     Creates a new JsonDataManager instance for the given file name.
        /// </summary>
        /// <param name="fileName">The name of the file (excluding any directory paths) where data should be saved or loaded.</param>
        public JsonDataManager(string fileName)
        {
            _filePath = Path.Combine(Application.persistentDataPath, fileName);
        }

        /// <summary>
        ///     Gets the data object. If one was already loaded, returns that; otherwise, loads data from disk first.
        /// </summary>
        /// <returns>The data object.</returns>
        public T GetData()
        {
            if (_cachedData == null)
            {
                _cachedData = LoadDataFromDisk();
            }

            return _cachedData;
        }

        /// <summary>
        ///     Loads data from disk. If no data is present, returns a new instance of the data type.
        /// </summary>
        /// <returns>The loaded data object, or a new instance if no data could be loaded.</returns>
        private T LoadDataFromDisk()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    return JsonUtility.FromJson<T>(json);
                }

                Debug.LogWarning($"File not found: {_filePath}");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to load data from {_filePath}. Error: {ex.Message}");
            }

            return new T(); // Return a new instance if there's an error or the file doesn't exist.
        }

        /// <summary>
        ///     Saves the given data object to disk in JSON format, and caches it for subsequent get requests.
        /// </summary>
        /// <param name="data">The data object to save.</param>
        public void SaveData(T data)
        {
            try
            {
                string json = JsonUtility.ToJson(data, true);
                File.WriteAllText(_filePath, json);

                _cachedData = data; // Update the cache
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to save data to {_filePath}. Error: {ex.Message}");
            }
        }
    }
}