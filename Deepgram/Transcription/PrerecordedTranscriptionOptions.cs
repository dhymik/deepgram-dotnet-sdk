﻿using System;
using Newtonsoft.Json;

namespace Deepgram.Transcription
{
    public class PrerecordedTranscriptionOptions
    {
        /// <summary>
        /// AI model used to process submitted audio
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; } = null;

        /// <summary>
        /// Version of the model to use.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = null;

        /// <summary>
        /// BCP-47 language tag that hints at the primary spoken language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; } = null;

        /// <summary>
        /// Level of model you would like to use in your request.
        /// </summary>
        /// <remarks>Defaults to base. Possible values are: base, enhanced</remarks>
        [JsonProperty("tier")]
        public string Tier { get; set; } = null;

        /// <summary>
        /// Indicates whether to add punctuation and capitalization to the transcript.
        /// </summary>
        [JsonProperty("punctuate")]
        public Nullable<bool> Punctuate { get; set; } = null;

        /// <summary>
        /// Indicates whether to remove profanity from the transcript.
        /// </summary>
        [JsonProperty("profanity_filter")]
        public Nullable<bool> ProfanityFilter { get; set; } = null;

        /// <summary>
        /// Indicates whether to redact sensitive information, replacing redacted content with asterisks (*).
        /// </summary>
        /// <remarks>Possible values are: pci, numbers, ssn</remarks>
        [JsonProperty("redact")]
        public string[] Redaction { get; set; }

        /// <summary>
        /// Indicates whether to recognize speaker changes. When set to true, each word in the transcript
        /// will be assigned a speaker number starting at 0. 
        /// </summary>
        [JsonProperty("diarize")]
        public Nullable<bool> Diarize { get; set; } = null;

        /// <summary>
        /// Indicates which version of the diarizer to use. When passed in, each word in the transcript will
        /// be assigned a speaker number starting at 0. Ex: YYYY-MM-DD.X where YYYY-MM-DD is the version date
        ///  and X is the version number.
        /// </summary>
        [JsonProperty("diarize_version ")]
        public string DiarizationVersion { get; set; } = null;

        /// <summary>
        /// Indicates whether to recognize alphanumeric strings. When set to true, whitespace will be removed
        /// between characters identified as part of an alphanumeric string. 
        /// </summary>
        [JsonProperty("ner")]
        public Nullable<bool> NamedEntityRecognition { get; set; } = null;

        /// <summary>
        /// Indicates whether to transcribe each audio channel independently.
        /// </summary>
        [JsonProperty("multichannel")]
        public Nullable<bool> MultiChannel { get; set; } = null;

        /// <summary>
        /// Maximum number of transcript alternatives to return.
        /// </summary>
        [JsonProperty("alternatives")]
        public Nullable<int> Alternatives { get; set; } = null;

        /// <summary>
        /// Indicates whether to convert numbers from written format (e.g., one) to numerical format (e.g., 1).
        /// </summary>
        [JsonProperty("numerals")]
        public Nullable<bool> Numerals { get; set; } = null;

        /// <summary>
        /// Terms or phrases to search for in the submitted audio.
        /// </summary>
        [JsonProperty("search")]
        public string[] SearchTerms { get; set; }

        /// <summary>
        /// Terms or phrases to search for in the submitted audio and replace.
        /// </summary>
        /// <remarks>Phrases should be submitted in the format: searchfor:replacewith</remarks>
        [JsonProperty("replace")]
        public string[] Replace { get; set; }

        /// <summary>
        /// Callback URL to provide if you would like your submitted audio to be processed asynchronously.
        /// When passed, Deepgram will immediately respond with a request_id. 
        /// </summary>
        [JsonProperty("callback")]
        public string Callback { get; set; } = null;

        /// <summary>
        /// Keywords to which the model should pay particular attention to boosting or suppressing to help
        /// it understand context.
        /// </summary>
        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        /// <summary>
        /// Indicates whether Deepgram will segment speech into meaningful semantic units, which allows
        /// the model to interact more naturally and effectively with speakers' spontaneous speech patterns.
        /// </summary>
        [JsonProperty("utterances")]
        public Nullable<bool> Utterances { get; set; } = null;
        
        /// <summary>
        /// Indicates whether to detect the language of the provided audio.
        /// </summary>
        [JsonProperty("detect_language")]
        public Nullable<bool> DetectLanguage { get; set; } = null;

        /// <summary>
        /// Indicates whether Deepgram will split audio into paragraphs to improve transcript
        /// readability. When paragraphs is set to true, you must also set either punctuate, 
        /// diarize, or multichannel to true.
        /// </summary>
        [JsonProperty("paragraphs")]
        public Nullable<bool> Paragraphs { get; set; } = null;

        /// <summary>
        /// Length of time in seconds of silence between words that Deepgram will use when determining
        /// where to split utterances.
        /// </summary>
        [JsonProperty("utt_split")]
        public Nullable<decimal> UtteranceSplit { get; set; } = null;
    }
}
