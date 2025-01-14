## Generated classes

The command used to build the classes is the following:

```cmd
MASES.JNetReflector.exe -TraceLevel 0 -OriginRootPath %ANDROID_HOME%\platforms\android-35 -DestinationRootPath .\src\ -ConfigurationFile .\src\configuration.json
```

The configuration is:

```json
{
  "RelativeDestinationCSharpClassPath": "net\\Netdroid\\Generated",
  "RelativeDestinationJavaListenerPath": "jvm\\netdroid\\src\\main\\java",
  "JavaListenerBasePackage": "org.mases.netdroid.generated",
  "ReflectDeprecated": true,
  "PreferMethodWithSignature": true,
  "DisablePropertiesForGetterSetter": true,
  "DisableInterfaceMethodGeneration": true,
  "CreateInterfaceInheritance": true,
  "JarList": [
    "android.jar"
  ],
  "OriginJavadocJARVersionAndUrls": [
    {
      "Version": 11,
      "Url": "https://developer.android.com/reference/",
      "NoModule": true
    }
  ],
  "NamespacesToAvoid": [
    "com.oracle",
    "com.sun",
    "java.awt.peer",
    "java.lang.constant",
    "java.lang.runtime",
    "org.burningwave",
    "org.graalvm",
    "org.hamcrest",
    "org.jcp.xml.dsig.internal",
    "org.junit",
    "org.mases",
    "org.slf4j"
  ],
  "ClassesToBeListener": [
    "android.hardware.SensorEventListener2",
    "android.media.MediaScannerConnection$MediaScannerConnectionClient",
    "javax.swing.Action",
    "javax.management.NotificationFilter"
  ],
  "ClassesToRemoveAsListener": [
    "android.animation.AnimatorListenerAdapter",
    "android.bluetooth.BluetoothAdapter",
    "android.content.AbstractThreadedSyncAdapter",
    "android.hardware.TriggerEventListener",
    "android.net.sip.SipAudioCall$Listener",
    "android.net.sip.SipSession$Listener",
    "android.net.wifi.aware.IdentityChangedListener",
    "android.nfc.NfcAdapter",
    "android.os.storage.OnObbStateChangeListener",
    "android.print.PrintDocumentAdapter",
    "android.renderscript.AllocationAdapter",
    "android.speech.tts.UtteranceProgressListener",
    "android.telephony.PhoneStateListener",
    "android.telephony.SubscriptionManager$OnOpportunisticSubscriptionsChangedListener",
    "android.telephony.SubscriptionManager$OnSubscriptionsChangedListener",
    "android.telephony.ims.RcsUceAdapter",
    "android.telephony.mbms.DownloadProgressListener",
    "android.telephony.mbms.DownloadStatusListener",
    "android.text.method.DateKeyListener",
    "android.text.method.DateTimeKeyListener",
    "android.text.method.DialerKeyListener",
    "android.text.method.DigitsKeyListener",
    "android.text.method.MetaKeyKeyListener",
    "android.text.method.QwertyKeyListener",
    "android.text.method.TimeKeyListener",
    "android.widget.ArrayAdapter",
    "android.widget.CursorTreeAdapter",
    "android.widget.HeaderViewListAdapter",
    "android.widget.ResourceCursorAdapter",
    "android.widget.ResourceCursorTreeAdapter",
    "android.widget.SimpleCursorAdapter",
    "android.widget.SimpleCursorTreeAdapter",
    "android.widget.SimpleExpandableListAdapter",
    "android.view.OrientationEventListener",
    "android.view.accessibility.CaptioningManager$CaptioningChangeListener",
    "org.xml.sax.helpers.XMLReaderAdapter"
  ],
  "ClassesManuallyDeveloped": [
    "java.util.Comparator",
    "java.util.EventListener"
  ],
  "ClassesToAvoid": [
    "android.net.TransportInfo",
    "android.util.Range",
    "java.io.ObjectInputFilter",
    "java.lang.Enum$EnumDesc",
    "java.lang.Module",
    "java.lang.ModuleLayer",
    "java.lang.ProcessBuilder$Redirect$Type",
    "java.lang.ProcessHandle",
    "java.lang.ProcessHandle$Info",
    "java.lang.Runtime$Version",
    "java.lang.System$Logger",
    "java.lang.Thread$UncaughtExceptionHandler",
    "java.lang.invoke.VarHandle$VarHandleDesc",
    "java.lang.reflect.AnnotatedType",
    "java.security.SecureRandomParameters",
    "java.sql.ConnectionBuilder",
    "java.sql.DriverAction",
    "java.sql.ShardingKey",
    "java.sql.ShardingKeyBuilder",
    "java.sql.SQLType",
    "java.text.NumberFormat$Style",
    "java.time.chrono.ChronoLocalDateTime",
    "java.time.chrono.ChronoZonedDateTime",
    "java.util.stream.DoubleStream$Builder",
    "java.util.stream.DoubleStream$DoubleMapMultiConsumer",
    "java.util.stream.IntStream$Builder",
    "java.util.stream.IntStream$IntMapMultiConsumer",
    "java.util.stream.LongStream$Builder",
    "java.util.stream.LongStream$LongMapMultiConsumer",
    "java.util.stream.Stream$Builder",
    "java.util.ServiceLoader$Provider",
    "java.util.zip.ZipConstants",
    "javax.sql.PooledConnectionBuilder",
    "javax.xml.xpath.XPathEvaluationResult",
    "org.w3c.dom.ls.LSSerializerFilter"
  ],
  "ClassesToAvoidInGenerics": [
    "java.time.chrono.ChronoLocalDateTime",
    "java.time.chrono.ChronoZonedDateTime"
  ],
  "NamespacesInConflict": [
    "java.awt.color",
    "java.awt.desktop",
    "java.awt.image",
    "java.awt.event",
    "java.awt.font",
    "java.lang.module",
    "java.util.random"
  ]
}
```
