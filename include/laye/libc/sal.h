/// thank you to https://github.com/legends2k/NoSAL
/// for saving me a few lines of work :)
///
/// Copyright 2021 Sundaram Ramaswamy
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///     http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

#pragma once

#ifdef _In_
#undef _In_
#endif
#define _In_

#ifdef _Inout_
#undef _Inout_
#endif
#define _Inout_

#ifdef _Out_
#undef _Out_
#endif
#define _Out_

#ifdef _In_z_
#undef _In_z_
#endif
#define _In_z_

#ifdef _Out_z_
#undef _Out_z_
#endif
#define _Out_z_

#ifdef _Inout_z_
#undef _Inout_z_
#endif
#define _Inout_z_

#ifdef _In_opt_
#undef _In_opt_
#endif
#define _In_opt_

#ifdef _Out_opt_
#undef _Out_opt_
#endif
#define _Out_opt_

#ifdef _Inout_opt_
#undef _Inout_opt_
#endif
#define _Inout_opt_

#ifdef _Out_writes_
#undef _Out_writes_
#endif
#define _Out_writes_(x)

#ifdef _Out_writes_opt_
#undef _Out_writes_opt_
#endif
#define _Out_writes_opt_(x)

#ifdef _In_reads_
#undef _In_reads_
#endif
#define _In_reads_(x)

#ifdef _Inout_updates_bytes_
#undef _Inout_updates_bytes_
#endif
#define _Inout_updates_bytes_(x)


#ifdef _Use_decl_annotations_
#undef _Use_decl_annotations_
#endif
#define _Use_decl_annotations_

#ifdef _Analysis_assume_
#undef _Analysis_assume_
#endif
#define _Analysis_assume_(x)

#ifdef _Out_writes_bytes_
#undef _Out_writes_bytes_
#endif
#define _Out_writes_bytes_(x)

#ifdef _In_reads_bytes_
#undef _In_reads_bytes_
#endif
#define _In_reads_bytes_(x)

#ifdef _Success_
#undef _Success_
#endif
#define _Success_(x)
