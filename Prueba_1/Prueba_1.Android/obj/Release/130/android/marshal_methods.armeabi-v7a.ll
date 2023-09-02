; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [94 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 43
	i32 57263871, ; 1: Xamarin.Forms.Core.dll => 0x369c6ff => 38
	i32 182336117, ; 2: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 35
	i32 318968648, ; 3: Xamarin.AndroidX.Activity.dll => 0x13031348 => 19
	i32 321597661, ; 4: System.Numerics => 0x132b30dd => 16
	i32 342366114, ; 5: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 29
	i32 347068432, ; 6: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 11
	i32 442521989, ; 7: Xamarin.Essentials => 0x1a605985 => 37
	i32 450948140, ; 8: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 27
	i32 465846621, ; 9: mscorlib => 0x1bc4415d => 6
	i32 469710990, ; 10: System.dll => 0x1bff388e => 15
	i32 627609679, ; 11: Xamarin.AndroidX.CustomView => 0x2568904f => 25
	i32 748832960, ; 12: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 9
	i32 809851609, ; 13: System.Drawing.Common.dll => 0x30455ad9 => 45
	i32 928116545, ; 14: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 43
	i32 967690846, ; 15: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 29
	i32 974778368, ; 16: FormsViewGroup.dll => 0x3a19f000 => 3
	i32 1012816738, ; 17: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 34
	i32 1035644815, ; 18: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 21
	i32 1042160112, ; 19: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 40
	i32 1052210849, ; 20: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 31
	i32 1098259244, ; 21: System => 0x41761b2c => 15
	i32 1244939367, ; 22: Prueba_1.Android.dll => 0x4a344467 => 0
	i32 1292207520, ; 23: SQLitePCLRaw.core.dll => 0x4d0585a0 => 10
	i32 1293217323, ; 24: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 26
	i32 1320691800, ; 25: Prueba_1 => 0x4eb82858 => 7
	i32 1365406463, ; 26: System.ServiceModel.Internals.dll => 0x516272ff => 44
	i32 1376866003, ; 27: Xamarin.AndroidX.SavedState => 0x52114ed3 => 34
	i32 1406073936, ; 28: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 23
	i32 1411638395, ; 29: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 17
	i32 1460219004, ; 30: Xamarin.Forms.Xaml => 0x57092c7c => 41
	i32 1469204771, ; 31: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 20
	i32 1592978981, ; 32: System.Runtime.Serialization.dll => 0x5ef2ee25 => 2
	i32 1622152042, ; 33: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 32
	i32 1639515021, ; 34: System.Net.Http.dll => 0x61b9038d => 1
	i32 1658251792, ; 35: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 42
	i32 1711441057, ; 36: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 11
	i32 1729485958, ; 37: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 22
	i32 1766324549, ; 38: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 35
	i32 1776026572, ; 39: System.Core.dll => 0x69dc03cc => 14
	i32 1788241197, ; 40: Xamarin.AndroidX.Fragment => 0x6a96652d => 27
	i32 1808609942, ; 41: Xamarin.AndroidX.Loader => 0x6bcd3296 => 32
	i32 1813201214, ; 42: Xamarin.Google.Android.Material => 0x6c13413e => 42
	i32 1867746548, ; 43: Xamarin.Essentials.dll => 0x6f538cf4 => 37
	i32 1878053835, ; 44: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 41
	i32 2011961780, ; 45: System.Buffers.dll => 0x77ec19b4 => 13
	i32 2019465201, ; 46: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 31
	i32 2055257422, ; 47: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 30
	i32 2097448633, ; 48: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 28
	i32 2103459038, ; 49: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 12
	i32 2126786730, ; 50: Xamarin.Forms.Platform.Android => 0x7ec430aa => 39
	i32 2201231467, ; 51: System.Net.Http => 0x8334206b => 1
	i32 2219945322, ; 52: Prueba_1.dll => 0x8451ad6a => 7
	i32 2279755925, ; 53: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 33
	i32 2465273461, ; 54: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 9
	i32 2475788418, ; 55: Java.Interop.dll => 0x93918882 => 4
	i32 2732626843, ; 56: Xamarin.AndroidX.Activity => 0xa2e0939b => 19
	i32 2737747696, ; 57: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 20
	i32 2766581644, ; 58: Xamarin.Forms.Core => 0xa4e6af8c => 38
	i32 2778768386, ; 59: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 36
	i32 2810250172, ; 60: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 23
	i32 2819470561, ; 61: System.Xml.dll => 0xa80db4e1 => 18
	i32 2853208004, ; 62: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 36
	i32 2905242038, ; 63: mscorlib.dll => 0xad2a79b6 => 6
	i32 2978675010, ; 64: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 26
	i32 3044182254, ; 65: FormsViewGroup => 0xb57288ee => 3
	i32 3111772706, ; 66: System.Runtime.Serialization => 0xb979e222 => 2
	i32 3247949154, ; 67: Mono.Security => 0xc197c562 => 46
	i32 3258312781, ; 68: Xamarin.AndroidX.CardView => 0xc235e84d => 22
	i32 3286872994, ; 69: SQLite-net.dll => 0xc3e9b3a2 => 8
	i32 3317135071, ; 70: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 25
	i32 3353484488, ; 71: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 28
	i32 3360279109, ; 72: SQLitePCLRaw.core => 0xc849ca45 => 10
	i32 3362522851, ; 73: Xamarin.AndroidX.Core => 0xc86c06e3 => 24
	i32 3366347497, ; 74: Java.Interop => 0xc8a662e9 => 4
	i32 3374999561, ; 75: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 33
	i32 3395150330, ; 76: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 17
	i32 3404865022, ; 77: System.ServiceModel.Internals => 0xcaf21dfe => 44
	i32 3429136800, ; 78: System.Xml => 0xcc6479a0 => 18
	i32 3476120550, ; 79: Mono.Android => 0xcf3163e6 => 5
	i32 3536029504, ; 80: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 39
	i32 3632359727, ; 81: Xamarin.Forms.Platform => 0xd881692f => 40
	i32 3641597786, ; 82: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 30
	i32 3672681054, ; 83: Mono.Android.dll => 0xdae8aa5e => 5
	i32 3689375977, ; 84: System.Drawing.Common => 0xdbe768e9 => 45
	i32 3729486572, ; 85: Prueba_1.Android => 0xde4b72ec => 0
	i32 3754567612, ; 86: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 12
	i32 3829621856, ; 87: System.Numerics.dll => 0xe4436460 => 16
	i32 3876362041, ; 88: SQLite-net => 0xe70c9739 => 8
	i32 3896760992, ; 89: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 24
	i32 3955647286, ; 90: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 21
	i32 4105002889, ; 91: Mono.Security.dll => 0xf4ad5f89 => 46
	i32 4151237749, ; 92: System.Core => 0xf76edc75 => 14
	i32 4260525087 ; 93: System.Buffers => 0xfdf2741f => 13
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [94 x i32] [
	i32 43, i32 38, i32 35, i32 19, i32 16, i32 29, i32 11, i32 37, ; 0..7
	i32 27, i32 6, i32 15, i32 25, i32 9, i32 45, i32 43, i32 29, ; 8..15
	i32 3, i32 34, i32 21, i32 40, i32 31, i32 15, i32 0, i32 10, ; 16..23
	i32 26, i32 7, i32 44, i32 34, i32 23, i32 17, i32 41, i32 20, ; 24..31
	i32 2, i32 32, i32 1, i32 42, i32 11, i32 22, i32 35, i32 14, ; 32..39
	i32 27, i32 32, i32 42, i32 37, i32 41, i32 13, i32 31, i32 30, ; 40..47
	i32 28, i32 12, i32 39, i32 1, i32 7, i32 33, i32 9, i32 4, ; 48..55
	i32 19, i32 20, i32 38, i32 36, i32 23, i32 18, i32 36, i32 6, ; 56..63
	i32 26, i32 3, i32 2, i32 46, i32 22, i32 8, i32 25, i32 28, ; 64..71
	i32 10, i32 24, i32 4, i32 33, i32 17, i32 44, i32 18, i32 5, ; 72..79
	i32 39, i32 40, i32 30, i32 5, i32 45, i32 0, i32 12, i32 16, ; 80..87
	i32 8, i32 24, i32 21, i32 46, i32 14, i32 13 ; 88..93
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
