//
//  TalkableWrapperApi.h
//  TalkableWrapper
//
//  Created by admin on 28.11.2021.
//

#import <Foundation/Foundation.h>
#import <TalkableSDK/Talkable.h>

NS_ASSUME_NONNULL_BEGIN

@interface TalkableWrapperApi : NSObject
{
    
}
- (void)setApiKey:(NSString* _Nullable)apiKey andSiteSlug:(NSString* _Nullable)siteSlug;
- (BOOL)handleOpenURL:(NSURL* _Nullable)url;
@end

NS_ASSUME_NONNULL_END
