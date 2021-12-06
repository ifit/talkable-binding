//
//  TalkableWrapperApi.m
//  TalkableWrapper
//
//  Created by admin on 28.11.2021.
//

#import "TalkableWrapperApi.h"


@implementation TalkableWrapperApi
- (void)setApiKey:(NSString* _Nullable)apiKey andSiteSlug:(NSString* _Nullable)siteSlug {
    [[Talkable manager] setApiKey:apiKey andSiteSlug:siteSlug];
}

- (BOOL)handleOpenURL:(NSURL* _Nullable)url {
    return [[Talkable manager] handleOpenURL:url];
}

@end
