using System;
using CoreFoundation;
using Foundation;
using mobileffmpeg;

namespace Laerdal.FFmpeg.iOS
{
	// @interface ArchDetect : NSObject
	[BaseType (typeof(NSObject))]
	interface ArchDetect
	{
		// +(NSString *)getCpuArch;
		[Static]
		[Export ("getCpuArch")]
		[Verify (MethodToProperty)]
		string CpuArch { get; }

		// +(NSString *)getArch;
		[Static]
		[Export ("getArch")]
		[Verify (MethodToProperty)]
		string Arch { get; }

		// +(int)isLTSBuild;
		[Static]
		[Export ("isLTSBuild")]
		[Verify (MethodToProperty)]
		int IsLTSBuild { get; }
	}

	// @interface AtomicLong : NSObject
	[BaseType (typeof(NSObject))]
	interface AtomicLong
	{
		// -(instancetype)initWithInitialValue:(long)initialValue;
		[Export ("initWithInitialValue:")]
		IntPtr Constructor (nint initialValue);

		// -(long)incrementAndGet;
		[Export ("incrementAndGet")]
		[Verify (MethodToProperty)]
		nint IncrementAndGet { get; }
	}

	// @protocol ExecuteDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface ExecuteDelegate
	{
		// @required -(void)executeCallback:(long)executionId :(int)returnCode;
		[Abstract]
		[Export ("executeCallback::")]
		void  (nint executionId, int returnCode);
	}

	// @interface FFmpegExecution : NSObject
	[BaseType (typeof(NSObject))]
	interface FFmpegExecution
	{
		// -(instancetype)initWithExecutionId:(long)newExecutionId andArguments:(NSArray *)arguments;
		[Export ("initWithExecutionId:andArguments:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (nint newExecutionId, NSObject[] arguments);

		// -(NSDate *)getStartTime;
		[Export ("getStartTime")]
		[Verify (MethodToProperty)]
		NSDate StartTime { get; }

		// -(long)getExecutionId;
		[Export ("getExecutionId")]
		[Verify (MethodToProperty)]
		nint ExecutionId { get; }

		// -(NSString *)getCommand;
		[Export ("getCommand")]
		[Verify (MethodToProperty)]
		string Command { get; }
	}

	// @protocol LogDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface LogDelegate
	{
		// @required -(void)logCallback:(long)executionId :(int)level :(NSString *)message;
		[Abstract]
		[Export ("logCallback:::")]
		void  (nint executionId, int level, string message);
	}

	// @interface StreamInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface StreamInformation
	{
		// -(instancetype)init:(NSDictionary *)streamDictionary;
		[Export ("init:")]
		IntPtr Constructor (NSDictionary streamDictionary);

		// -(NSNumber *)getIndex;
		[Export ("getIndex")]
		[Verify (MethodToProperty)]
		NSNumber Index { get; }

		// -(NSString *)getType;
		[Export ("getType")]
		[Verify (MethodToProperty)]
		string Type { get; }

		// -(NSString *)getCodec;
		[Export ("getCodec")]
		[Verify (MethodToProperty)]
		string Codec { get; }

		// -(NSString *)getFullCodec;
		[Export ("getFullCodec")]
		[Verify (MethodToProperty)]
		string FullCodec { get; }

		// -(NSString *)getFormat;
		[Export ("getFormat")]
		[Verify (MethodToProperty)]
		string Format { get; }

		// -(NSNumber *)getWidth;
		[Export ("getWidth")]
		[Verify (MethodToProperty)]
		NSNumber Width { get; }

		// -(NSNumber *)getHeight;
		[Export ("getHeight")]
		[Verify (MethodToProperty)]
		NSNumber Height { get; }

		// -(NSString *)getBitrate;
		[Export ("getBitrate")]
		[Verify (MethodToProperty)]
		string Bitrate { get; }

		// -(NSString *)getSampleRate;
		[Export ("getSampleRate")]
		[Verify (MethodToProperty)]
		string SampleRate { get; }

		// -(NSString *)getSampleFormat;
		[Export ("getSampleFormat")]
		[Verify (MethodToProperty)]
		string SampleFormat { get; }

		// -(NSString *)getChannelLayout;
		[Export ("getChannelLayout")]
		[Verify (MethodToProperty)]
		string ChannelLayout { get; }

		// -(NSString *)getSampleAspectRatio;
		[Export ("getSampleAspectRatio")]
		[Verify (MethodToProperty)]
		string SampleAspectRatio { get; }

		// -(NSString *)getDisplayAspectRatio;
		[Export ("getDisplayAspectRatio")]
		[Verify (MethodToProperty)]
		string DisplayAspectRatio { get; }

		// -(NSString *)getAverageFrameRate;
		[Export ("getAverageFrameRate")]
		[Verify (MethodToProperty)]
		string AverageFrameRate { get; }

		// -(NSString *)getRealFrameRate;
		[Export ("getRealFrameRate")]
		[Verify (MethodToProperty)]
		string RealFrameRate { get; }

		// -(NSString *)getTimeBase;
		[Export ("getTimeBase")]
		[Verify (MethodToProperty)]
		string TimeBase { get; }

		// -(NSString *)getCodecTimeBase;
		[Export ("getCodecTimeBase")]
		[Verify (MethodToProperty)]
		string CodecTimeBase { get; }

		// -(NSDictionary *)getTags;
		[Export ("getTags")]
		[Verify (MethodToProperty)]
		NSDictionary Tags { get; }

		// -(NSString *)getStringProperty:(NSString *)key;
		[Export ("getStringProperty:")]
		string GetStringProperty (string key);

		// -(NSNumber *)getNumberProperty:(NSString *)key;
		[Export ("getNumberProperty:")]
		NSNumber GetNumberProperty (string key);

		// -(NSDictionary *)getProperties:(NSString *)key;
		[Export ("getProperties:")]
		NSDictionary GetProperties (string key);

		// -(NSDictionary *)getAllProperties;
		[Export ("getAllProperties")]
		[Verify (MethodToProperty)]
		NSDictionary AllProperties { get; }
	}

	// @interface MediaInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface MediaInformation
	{
		// -(instancetype)init:(NSDictionary *)mediaDictionary withStreams:(NSArray *)streams;
		[Export ("init:withStreams:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (NSDictionary mediaDictionary, NSObject[] streams);

		// -(NSString *)getFilename;
		[Export ("getFilename")]
		[Verify (MethodToProperty)]
		string Filename { get; }

		// -(NSString *)getFormat;
		[Export ("getFormat")]
		[Verify (MethodToProperty)]
		string Format { get; }

		// -(NSString *)getLongFormat;
		[Export ("getLongFormat")]
		[Verify (MethodToProperty)]
		string LongFormat { get; }

		// -(NSString *)getDuration;
		[Export ("getDuration")]
		[Verify (MethodToProperty)]
		string Duration { get; }

		// -(NSString *)getStartTime;
		[Export ("getStartTime")]
		[Verify (MethodToProperty)]
		string StartTime { get; }

		// -(NSString *)getSize;
		[Export ("getSize")]
		[Verify (MethodToProperty)]
		string Size { get; }

		// -(NSString *)getBitrate;
		[Export ("getBitrate")]
		[Verify (MethodToProperty)]
		string Bitrate { get; }

		// -(NSDictionary *)getTags;
		[Export ("getTags")]
		[Verify (MethodToProperty)]
		NSDictionary Tags { get; }

		// -(NSArray *)getStreams;
		[Export ("getStreams")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Streams { get; }

		// -(NSString *)getStringProperty:(NSString *)key;
		[Export ("getStringProperty:")]
		string GetStringProperty (string key);

		// -(NSNumber *)getNumberProperty:(NSString *)key;
		[Export ("getNumberProperty:")]
		NSNumber GetNumberProperty (string key);

		// -(NSDictionary *)getProperties:(NSString *)key;
		[Export ("getProperties:")]
		NSDictionary GetProperties (string key);

		// -(NSDictionary *)getMediaProperties;
		[Export ("getMediaProperties")]
		[Verify (MethodToProperty)]
		NSDictionary MediaProperties { get; }

		// -(NSDictionary *)getAllProperties;
		[Export ("getAllProperties")]
		[Verify (MethodToProperty)]
		NSDictionary AllProperties { get; }
	}

	// @interface MediaInformationParser : NSObject
	[BaseType (typeof(NSObject))]
	interface MediaInformationParser
	{
		// +(MediaInformation *)from:(NSString *)ffprobeJsonOutput;
		[Static]
		[Export ("from:")]
		MediaInformation From (string ffprobeJsonOutput);

		// +(MediaInformation *)from:(NSString *)ffprobeJsonOutput with:(NSError *)error;
		[Static]
		[Export ("from:with:")]
		MediaInformation From (string ffprobeJsonOutput, NSError error);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MOBILE_FFMPEG_VERSION;
		[Field ("MOBILE_FFMPEG_VERSION", "__Internal")]
		NSString MOBILE_FFMPEG_VERSION { get; }
	}

	// @interface MobileFFmpeg : NSObject
	[BaseType (typeof(NSObject))]
	interface MobileFFmpeg
	{
		// +(int)executeWithArguments:(NSArray *)arguments;
		[Static]
		[Export ("executeWithArguments:")]
		[Verify (StronglyTypedNSArray)]
		int ExecuteWithArguments (NSObject[] arguments);

		// +(int)executeWithArgumentsAsync:(NSArray *)arguments withCallback:(id<ExecuteDelegate>)delegate;
		[Static]
		[Export ("executeWithArgumentsAsync:withCallback:")]
		[Verify (StronglyTypedNSArray)]
		int ExecuteWithArgumentsAsync (NSObject[] arguments, ExecuteDelegate @delegate);

		// +(int)executeWithArgumentsAsync:(NSArray *)arguments withCallback:(id<ExecuteDelegate>)delegate andDispatchQueue:(dispatch_queue_t)queue;
		[Static]
		[Export ("executeWithArgumentsAsync:withCallback:andDispatchQueue:")]
		[Verify (StronglyTypedNSArray)]
		int ExecuteWithArgumentsAsync (NSObject[] arguments, ExecuteDelegate @delegate, DispatchQueue queue);

		// +(int)execute:(NSString *)command;
		[Static]
		[Export ("execute:")]
		int Execute (string command);

		// +(int)executeAsync:(NSString *)command withCallback:(id<ExecuteDelegate>)delegate;
		[Static]
		[Export ("executeAsync:withCallback:")]
		int ExecuteAsync (string command, ExecuteDelegate @delegate);

		// +(int)executeAsync:(NSString *)command withCallback:(id<ExecuteDelegate>)delegate andDispatchQueue:(dispatch_queue_t)queue;
		[Static]
		[Export ("executeAsync:withCallback:andDispatchQueue:")]
		int ExecuteAsync (string command, ExecuteDelegate @delegate, DispatchQueue queue);

		// +(int)execute:(NSString *)command delimiter:(NSString *)delimiter __attribute__((deprecated("")));
		[Static]
		[Export ("execute:delimiter:")]
		int Execute (string command, string delimiter);

		// +(void)cancel;
		[Static]
		[Export ("cancel")]
		void Cancel ();

		// +(void)cancel:(long)executionId;
		[Static]
		[Export ("cancel:")]
		void Cancel (nint executionId);

		// +(NSArray *)parseArguments:(NSString *)command;
		[Static]
		[Export ("parseArguments:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ParseArguments (string command);

		// +(NSString *)argumentsToString:(NSArray *)arguments;
		[Static]
		[Export ("argumentsToString:")]
		[Verify (StronglyTypedNSArray)]
		string ArgumentsToString (NSObject[] arguments);

		// +(NSArray *)listExecutions;
		[Static]
		[Export ("listExecutions")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] ListExecutions { get; }
	}

	// @interface Statistics : NSObject
	[BaseType (typeof(NSObject))]
	interface Statistics
	{
		// -(instancetype)initWithId:(long)currentExecutionId videoFrameNumber:(int)newVideoFrameNumber fps:(float)newVideoFps quality:(float)newVideoQuality size:(int64_t)newSize time:(int)newTime bitrate:(double)newBitrate speed:(double)newSpeed;
		[Export ("initWithId:videoFrameNumber:fps:quality:size:time:bitrate:speed:")]
		IntPtr Constructor (nint currentExecutionId, int newVideoFrameNumber, float newVideoFps, float newVideoQuality, long newSize, int newTime, double newBitrate, double newSpeed);

		// -(void)update:(Statistics *)statistics;
		[Export ("update:")]
		void Update (Statistics statistics);

		// -(long)getExecutionId;
		[Export ("getExecutionId")]
		[Verify (MethodToProperty)]
		nint ExecutionId { get; }

		// -(int)getVideoFrameNumber;
		[Export ("getVideoFrameNumber")]
		[Verify (MethodToProperty)]
		int VideoFrameNumber { get; }

		// -(float)getVideoFps;
		[Export ("getVideoFps")]
		[Verify (MethodToProperty)]
		float VideoFps { get; }

		// -(float)getVideoQuality;
		[Export ("getVideoQuality")]
		[Verify (MethodToProperty)]
		float VideoQuality { get; }

		// -(long)getSize;
		[Export ("getSize")]
		[Verify (MethodToProperty)]
		nint Size { get; }

		// -(int)getTime;
		[Export ("getTime")]
		[Verify (MethodToProperty)]
		int Time { get; }

		// -(double)getBitrate;
		[Export ("getBitrate")]
		[Verify (MethodToProperty)]
		double Bitrate { get; }

		// -(double)getSpeed;
		[Export ("getSpeed")]
		[Verify (MethodToProperty)]
		double Speed { get; }
	}

	// @protocol StatisticsDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface StatisticsDelegate
	{
		// @required -(void)statisticsCallback:(Statistics *)statistics;
		[Abstract]
		[Export ("statisticsCallback:")]
		void StatisticsCallback (Statistics statistics);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int RETURN_CODE_SUCCESS;
		[Field ("RETURN_CODE_SUCCESS", "__Internal")]
		int RETURN_CODE_SUCCESS { get; }

		// extern const int RETURN_CODE_CANCEL;
		[Field ("RETURN_CODE_CANCEL", "__Internal")]
		int RETURN_CODE_CANCEL { get; }

		// extern NSString *const LIB_NAME;
		[Field ("LIB_NAME", "__Internal")]
		NSString LIB_NAME { get; }
	}

	// @interface MobileFFmpegConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface MobileFFmpegConfig
	{
		// +(void)enableRedirection;
		[Static]
		[Export ("enableRedirection")]
		void EnableRedirection ();

		// +(void)disableRedirection;
		[Static]
		[Export ("disableRedirection")]
		void DisableRedirection ();

		// +(int)getLogLevel;
		[Static]
		[Export ("getLogLevel")]
		[Verify (MethodToProperty)]
		int LogLevel { get; }

		// +(void)setLogLevel:(int)level;
		[Static]
		[Export ("setLogLevel:")]
		void SetLogLevel (int level);

		// +(NSString *)logLevelToString:(int)level;
		[Static]
		[Export ("logLevelToString:")]
		string LogLevelToString (int level);

		// +(void)setLogDelegate:(id<LogDelegate>)newLogDelegate;
		[Static]
		[Export ("setLogDelegate:")]
		void SetLogDelegate (LogDelegate newLogDelegate);

		// +(void)setStatisticsDelegate:(id<StatisticsDelegate>)newStatisticsDelegate;
		[Static]
		[Export ("setStatisticsDelegate:")]
		void SetStatisticsDelegate (StatisticsDelegate newStatisticsDelegate);

		// +(Statistics *)getLastReceivedStatistics;
		[Static]
		[Export ("getLastReceivedStatistics")]
		[Verify (MethodToProperty)]
		Statistics LastReceivedStatistics { get; }

		// +(void)resetStatistics;
		[Static]
		[Export ("resetStatistics")]
		void ResetStatistics ();

		// +(void)setFontconfigConfigurationPath:(NSString *)path;
		[Static]
		[Export ("setFontconfigConfigurationPath:")]
		void SetFontconfigConfigurationPath (string path);

		// +(void)setFontDirectory:(NSString *)fontDirectoryPath with:(NSDictionary *)fontNameMapping;
		[Static]
		[Export ("setFontDirectory:with:")]
		void SetFontDirectory (string fontDirectoryPath, NSDictionary fontNameMapping);

		// +(NSString *)getPackageName;
		[Static]
		[Export ("getPackageName")]
		[Verify (MethodToProperty)]
		string PackageName { get; }

		// +(NSArray *)getExternalLibraries;
		[Static]
		[Export ("getExternalLibraries")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] ExternalLibraries { get; }

		// +(NSString *)registerNewFFmpegPipe;
		[Static]
		[Export ("registerNewFFmpegPipe")]
		[Verify (MethodToProperty)]
		string RegisterNewFFmpegPipe { get; }

		// +(void)closeFFmpegPipe:(NSString *)ffmpegPipePath;
		[Static]
		[Export ("closeFFmpegPipe:")]
		void CloseFFmpegPipe (string ffmpegPipePath);

		// +(NSString *)getFFmpegVersion;
		[Static]
		[Export ("getFFmpegVersion")]
		[Verify (MethodToProperty)]
		string FFmpegVersion { get; }

		// +(NSString *)getVersion;
		[Static]
		[Export ("getVersion")]
		[Verify (MethodToProperty)]
		string Version { get; }

		// +(NSString *)getBuildDate;
		[Static]
		[Export ("getBuildDate")]
		[Verify (MethodToProperty)]
		string BuildDate { get; }

		// +(int)getLastReturnCode;
		[Static]
		[Export ("getLastReturnCode")]
		[Verify (MethodToProperty)]
		int LastReturnCode { get; }

		// +(NSString *)getLastCommandOutput;
		[Static]
		[Export ("getLastCommandOutput")]
		[Verify (MethodToProperty)]
		string LastCommandOutput { get; }

		// +(void)ignoreSignal:(int)signum;
		[Static]
		[Export ("ignoreSignal:")]
		void IgnoreSignal (int signum);
	}

	// @interface MobileFFprobe : NSObject
	[BaseType (typeof(NSObject))]
	interface MobileFFprobe
	{
		// +(int)executeWithArguments:(NSArray *)arguments;
		[Static]
		[Export ("executeWithArguments:")]
		[Verify (StronglyTypedNSArray)]
		int ExecuteWithArguments (NSObject[] arguments);

		// +(int)execute:(NSString *)command;
		[Static]
		[Export ("execute:")]
		int Execute (string command);

		// +(MediaInformation *)getMediaInformation:(NSString *)path;
		[Static]
		[Export ("getMediaInformation:")]
		MediaInformation GetMediaInformation (string path);

		// +(MediaInformation *)getMediaInformationFromCommand:(NSString *)command;
		[Static]
		[Export ("getMediaInformationFromCommand:")]
		MediaInformation GetMediaInformationFromCommand (string command);

		// +(MediaInformation *)getMediaInformation:(NSString *)path timeout:(long)timeout __attribute__((deprecated("")));
		[Static]
		[Export ("getMediaInformation:timeout:")]
		MediaInformation GetMediaInformation (string path, nint timeout);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern jmp_buf ex_buf__;
		[Field ("ex_buf__", "__Internal")]
		int[] ex_buf__ { get; }
	}
}
